Console Application<br/>
Exercise: Associative Arrays

# SoftUniExamResults
Judge statistics on the last Programing Fundamentals exam was not working correctly, so you have the task to take all the submissions and analyze them properly. You should collect all the submissions and print the final results and statistics about each language that the participants submitted their solutions in.<br/><br/>
You will be receiving lines in the following format: __"{username}-{language}-{points}" until you receive "exam finished"__. You should store each username and his submissions and points.<br/><br/>
You can receive a __command to ban__ a user for cheating in the following format: __"{username}-banned"__. In that case, you should __remove__ the user from the contest, but __preserve his submissions in the total count of submissions for each language__.<br/><br/>
After receiving __"exam finished"__ print each of the participants, ordered descending by their max points, then by username, in the following format:<br/><br/>
__Results:__<br/>
__{username} | {points}__<br/>
__…__<br/><br/>
After that print each language, used in the exam, ordered descending by total submission count and then by language name, in the following format:<br/><br/>
__Submissions:__<br/>
__{language} – {submissionsCount}__<br/>
__…__<br/><br/>
## Input / Constraints
* Until you receive __"exam finished"__ you will be receiving participant submissions in the following format:<br/> __"{username}-{language}-{points}"__.
* You can receive a ban command -> __"{username}-banned"__
* The points of the participant will always be a __valid integer in the range [0-100]__;
## Output
* Print the exam results for each participant, ordered descending by max points and then by username, in the following format:<br/><br/>
__Results:__<br/>
__{username} | {points}__<br/>
__…__
* After that print each language, ordered descending by total submissions and then by language name, in the following format:<br/><br/>
__Submissions:__<br/>
__{language} – {submissionsCount}__<br/>
__…__
* Allowed working __time / memory: 100ms / 16MB__.
## Examples
Input|Output|Comment
-----|------|-------
Peter-Java-84<br/>John-C#-84<br/>John -C#-70<br/>Kevin-C#-94<br/>exam finished|Results:<br/>Kevin \| 94<br/>John \| 84<br/>Peter \| 84<br/>Submissions:<br/>C# - 3<br/>Java - 1|We order the participants descending<br/> by max points and then by name, printing<br/> only the username and the max points.<br/>After that we print each language along with<br/> the count of submissions, ordered<br/> descending by submissions count, and then by language name.
Peter-Java-91<br/>John-C#-84<br/>Kevin-Java-90<br/>Kevin-C#-50<br/>Kevin-banned<br/>exam finished|Results:<br/>Peter \| 91<br/>John \| 84<br/>Submissions:<br/>C# - 2<br/>Java - 2|Kevin is banned so he is removed from the contest,<br/> but his submissions are still preserved in the languages submissions<br/> count. So although there are only 2<br/> participants in the results,<br/> there are 4 submissions in total.
