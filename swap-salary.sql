# Write your MySQL query statement below
Update salary 
SET sex = 
CASE 
    WHEN sex = 'm' THEN 'f'
    WHEN sex = 'f' THEN 'm'
END;

