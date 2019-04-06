[PROJECT]
~campus.ly (Student Info System)

[LANGUAGE]
~C#

[TOOLS]
~Forms
~MySQL

[DATABASE]
~Name : campus.ly
~Server: localhost
~Uid: student_admin
~Password: admin_student

[2DO]
ENROLL :
~remove student from class[D]
//Double Click pass Enroll instance (w/ stud and course id)


mods...

[PREP]

//Get sorted Ids
SELECT {TABLE NAME ID} FROM {TABLE NAME} ORDER BY {TABLE NAME ID} ASC 

//Update sorted Ids
**Multiple update queries inside iteration 

//Get max value id from sorted id via local variable (done in the loop)
ALTER TABLE tbl AUTO_INCREMENT = {MAX VALUE + 1};