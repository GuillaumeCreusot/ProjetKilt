﻿drop table if exists courreur;
drop table if exists course;
drop table if exists participation;
drop table if exists utilisateur;


create table utilisateur (
    id integer not null primary key auto_increment,
    nom varchar(100) not null,
    mdp_hash binary(64) not null
);

create table coureur (
    id integer not null primary key auto_increment,
    nom varchar(100) not null,
	prenom varchar(100) not null,
	mail varchar(100) not null,
	sexe varchar(100) not null,
	licence_ffa varchar(100) not null,
    date_naissance datetime not null
);

create table course (
	id integer not null primary key auto_increment,
	nom varchar(100) not null,
	kilometrage double not null
);

create table participation (
	id integer not null primary key auto_increment,
	num_dossard int not null,
	temps int not null,
	participant_id int null,
	course_id int null,
	constraint fk_coureur_participation foreign key(participant_id) references coureur(id),
	constraint fk_course_participation foreign key(course_id) references course(id)
);
