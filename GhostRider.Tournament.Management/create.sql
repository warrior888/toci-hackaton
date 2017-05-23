create table Participants (
	Id serial primary key,
	Name text
);

create table Tournament (
	Id serial primary key,
	Name text
);

create table Groups (
	Id serial primary key,
	TournamentId int references Tournament(Id)
);

create table GroupParticipants (
	Id serial primary key,
	GroupsId int references Groups(Id),
	ParticipantsId int references Participants(Id)
);