# Write your MySQL query statement below
SELECT firstName, lastName, city, state FROM Person P
LEFT JOIN Address A
on A.personId = P.personId 