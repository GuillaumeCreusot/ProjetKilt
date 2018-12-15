INSERT INTO `coureur` (`id`, `nom`, `prenom`, `mail`, `sexe`, `licence_ffa`, `date_naissance`) VALUES (NULL, 'Hache', 'Louis', 'lh', 'Yolo', 'Yolo', '1998-02-14 00:00:00'), (NULL, 'Creusot', 'Guigui', 'GC@officiel.fr', 'Officiel', 'Officielle', '1998-07-09 00:00:00');

INSERT INTO `coureur` (`id`, `nom`, `prenom`, `mail`, `sexe`, `licence_ffa`, `date_naissance`) VALUES (NULL, 'Rabile', 'Youyou', 'Habile', 'Habile', 'Habile', '2018-12-12 00:00:00'), (NULL, 'Du Hard', 'Claire', 'claireduhard@hard.fr', 'Hard', 'hard', '1988-09-10 00:00:00'), (NULL, 'GOMEZ', 'S', 'SGOMEZ', 'SGOMEZ', 'SGOMEZ', '1908-12-04 00:00:00'), (NULL, 'Bro', 'Ju', 'JuBro@bro.fr', 'Bro', 'Ju', '1999-04-24 00:00:00');

INSERT INTO `course` (`id`, `nom`, `kilometrage`) VALUES (NULL, 'Marathon de Bordeaux', '42'), (NULL, 'Tacourse', '0.75');

INSERT INTO `utilisateur` (`id`, `nom`, `mdp_hash`) VALUES (NULL, 'Utilisateur', 0x15112197219145891274157616724218510817136252737015419615822418216916320823413958144242);

INSERT INTO `participation` (`id`, `num_dossard`, `temps`, `participant_id`, `course_id`) VALUES (NULL, '42', '140', '6', '1'), (NULL, '666', '382', '4', '1'), (NULL, '1', '1', '6', '2'), (NULL, '2', '2', '2', '2'), (NULL, '3', '3', '4', '2'), (NULL, '4', '4', '5', '2'), (NULL, '5', '5', '1', '2'), (NULL, '6', '6', '3', '2');