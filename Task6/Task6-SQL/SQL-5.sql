SELECT DISTINCT t.*
FROM Teacher t
JOIN TeacherPupil tp ON t.TeacherID = tp.TeacherID
JOIN Pupil p ON tp.PupilID = p.PupilID
WHERE p.FirstName = 'Giorgi';