INSERT INTO Teacher (TeacherID, FirstName, LastName, Gender, Subject) 
VALUES
    (1, 'Nika', 'Kaxidze', 'M', 'Mathematics'),
    (2, 'Mariam', 'Xajomia', 'F', 'Science'),
    (3, 'Guram', 'Baramidze', 'M', 'History');


INSERT INTO Pupil (PupilID, FirstName, LastName, Gender, Class) 
VALUES
    (1, 'Luka', 'Svanidze', 'M', 'Grade 10'),
    (2, 'Davit', 'Kaxidze', 'M', 'Grade 11'),
    (3, 'Giorgi', 'Papashvili', 'M', 'Grade 10');

INSERT INTO TeacherPupil (TeacherID, PupilID) 
VALUES
    (1, 1),  
    (1, 2),  
    (2, 2),  
    (2, 3),  
    (3, 1),  
    (3, 3);  