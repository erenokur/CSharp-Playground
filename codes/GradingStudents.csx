// url: https://www.hackerrank.com/challenges/grading/problem
/* Solution explanation: 
    1. Create a for loop for all the elements of the array. 
    2. If the grade is less than 35 add it to the modified results. 
    3. If the grade is greater than 35 check if the difference between the grade and the next multiple of 5 is less than 3. 
    4. If it is less than 3 add the next multiple of 5 to the modified results. 
    5. If it is not less than 3 add the grade to the modified results. 
*/

public static List<int> gradingStudents(List<int> grades)
{
    List<int> modifiedResults = new List<int>();
    for (int i = 0; i < grades.Count(); i++)
    {
        int grade = grades[i];
        if (grade <= 35)
        {
            modifiedResults.Add(grade);
        }
        else
        {
            int checkGrade = (grade / 5) * 5 + 5;
            if (checkGrade - grade < 3)
            {
                modifiedResults.Add(checkGrade);
            }
            else
            {
                modifiedResults.Add(grade);
            }
        }

    }
    return modifiedResults;
}

gradingStudents(new List<int> { 73, 67, 38, 33 });