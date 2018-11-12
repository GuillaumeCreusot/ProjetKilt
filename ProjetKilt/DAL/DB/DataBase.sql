create database if not exists kilt character set utf8 collate utf8_unicode_ci;
use kilt;

grant all privileges on kilt.* to 'thierry'@'localhost' identified by 'kilt';