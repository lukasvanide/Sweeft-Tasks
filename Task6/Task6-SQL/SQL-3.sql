CREATE TABLE TeacherPupil (
    TeacherID INT,
    PupilID INT,
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
    FOREIGN KEY (PupilID) REFERENCES Pupil(PupilID),
    PRIMARY KEY (TeacherID, PupilID)
);