# TwaddleCate Master Project
This project contains the files that directly relate to the final project. All work shall be handled from here. For a more complete Readme, refer to [TwaddleCate](https://github.com/atmarnat/TwaddleCate#twaddlecate)
Below is a list of the TRRs for the project. All test cases are done locally, as I do not want to deploy them.


## Test Readiness Review: 11/3/2019
#### Entrance Criteria

| TestNo.      | Test Description | Test Method |
| -----------: | :--------------- | :---------: |
| 1            | User shall make an account | Analysis |
| 1.1          | User shall make a username | Demonstration |
| 1.2          | User shall make a password | Demonstration |
| 1.4          | User shall be able to update profile | Analysis |
| 2            | User shall create a message | Test |
| 2.1          | User shall delete a message | Test |
| 3            | Website shall display messages | Inspection  |
| 3.1          | Website shall group messages by discussion | Analysis |
| 3.2          | Website shall update discussion list when new discussion created | Analysis |
| 4            | Views shall display correctly | Inspection |
| 4.1          | Menu shall point to the correct views | Demonstration |
| 4.2          | HomePage shall point to topic views and login information | Demonstration |
| 4.3          | Topic views shall have list of discussions | Inspection |
| 4.3.1        | Topic views shall arrange discussions by date of last post | Test |
| 4.4          | Discussion views shall have a list of messages | Inspection  |
| 4.4.1        | User pictures shall display properly | Inspection |

#### Requirements Traceability

|       | User Login | Message Creation | Message Handling | Website Layout |
| ----: | :--------: | :--------------: | :--------------: | :------------: |
| 1     | OK         |                  |                  |                |
| 1.1   | OK         |                  |                  |                |
| 1.2   | OK         |                  |                  |                |
| 1.4   | OK         |                  |                  |                |
| 2     |            | OK               |                  |                |
| 2.1   |            | OK               |                  |                |
| 3     |            |                  | OK               |                |
| 3.1   |            |                  | OK               |                |
| 3.2   |            |                  | OK               |                |
| 4     |            |                  |                  | XX             |
| 4.1   |            |                  |                  | OK             |
| 4.2   |            |                  |                  | OK             |
| 4.3   |            |                  |                  | OK             |
| 4.3.1 |            |                  |                  | OK             |
| 4.4   |            |                  |                  | OK             |
| 4.4.1 |            |                  |                  | FAILED         |

#### Exit Criteria

| TestNo.      | Status     | Build     | TimeStamp | Requirement       | Test Procedure |
| -----------: | :--------: | :-------: | :-------: | :---------------: | :------------: |
| 1            | Passed     | 1.0       | 11/3/2019 | User Login        | Enter the pw/username/(default)picture, update all three |
| 1.1          | Passed     | 1.0       | 11/3/2019 |                   | unit test |
| 1.2          | Passed     | 1.0       | 11/3/2019 |                   | unit test |
| 1.4          | Passed     | 1.0       | 11/3/2019 |                   | unit test group(checking if all information is changed) |
| 2            | Passed     | 1.0       | 11/3/2019 | Message Creation  | unit test |
| 2.1          | Passed     | 1.0       | 11/3/2019 |                   | unit test |
| 3            | Passed     | 1.0       | 11/3/2019 | Message Handling  | View the webpage to verify information |
| 3.1          | Passed     | 1.0       | 11/3/2019 |                   | unit test group verifying correct information from database |
| 3.2          | Passed     | 1.0       | 11/3/2019 |                   | unit test group checking for message on both pages |
| 4            | XX         | 1.0       | 11/3/2019 | Website Layout    | View page and see if everything is lined up correctly |
| 4.1          | Passed     | 1.0       | 11/3/2019 |                   | Click links to see if they point to right locations |
| 4.2          | Passed     | 1.0       | 11/3/2019 |                   | Click links to see if they point to right locations |
| 4.3          | Passed     | 1.0       | 11/3/2019 |                   | View the page and see if there are messages |
| 4.3.1        | Passed     | 1.0       | 11/3/2019 |                   | unit test (by time ordering) |
| 4.4          | Passed     | 1.0       | 11/3/2019 |                   | View page and see if there are messages |
| 4.4.1        | Failed     | 1.0       | 11/3/2019 |                   | View if pictures are uploading correctly |



