# Clinic App

## Group 4
Alden Lien, David Macababayao, Frank Ma, Joshua Kim, Arhum Ladak

###### Made to be used on Industry Standard Monitor Resolutions (at least 1080p)

### Installation Instructions
#### With Visual Studio
1. Open the ClinicApp.sln solution with Visual Studio
2. Build the program (CTRL + B)
3. Use Visual Studios player to run the app (green start button at the top) OR
4. Run the Application executable in ClinicApp/src/bin/Debug

### User Instructions
#### Adding an Appointment 
1. Click the 'Add Appointment' button located in the right sidebar (available to every page)
2. Select a client to continue: <br />
   2.1 If you know the client already exists in the system press the 'Existing Client' button on the right <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.1.1 Either scroll or use the search feature to search by name to find the desired client<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.1.2 Click on the targeted client to move onto the next step<br />
  2.2 If the client is not already registered use the new client feature on the left<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.2.1 Enter the clients first name in the top text box and last name in the middle text box.<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.2.2 Enter either a phone number or email address following the placeholder format or any other common readable format.<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.2.3 Once all three fields are entered click 'Next' to continue.
3. Select one of the tabs (30 minutes, 60 minutes, or 90minutes) to set a duration for the appointment.
4. Select the reason for visit either amoung the provided options or fill in the reason for visit manually using the other text box.
5. Click 'Next' to continue to date selection.
6. The date is automatically set to the current date so, use the calendar date picker to select the desired date for the appointment.
7. Choose which doctor you want to handle the appointment and select one of the available timeslots below the doctors name.
8. Press 'Confirm' in the bottom right to finialize the appointment. 
#### Adding a Client
1. Click the 'Add Client' button located in the right sidebar (available to every page except add appointment page)
2. Fill out the fields with a required tag with information matching the labels (First name, Last name, and Phone number).
3. Fill out any additional information the user knows about the client.
4. Click 'Add' button to create the client.
#### Adding a Doctor
1. Click the 'Add Doctor' button located in the right sidebar (available to every page except add appointment page)
2. Fill out the fields with a required tag with information matching the labels. (First name, Last name, and Phone number).
3. Fill out any additional information the user knows about the Doctor.
4. Click 'Add' button to create the doctor.
#### Access Appointment Details
Accessible through four methods:
##### Method 1: If the targeted appointment is on the current day
1. Look at the upcoming appointments section in the side bar, if you do not see the side bar navigate to any page using the top navbar.
2. Scroll through the list until you find the desired appointment.
3. Click on the list item with the desired appointment details.
4. Then the appointment details will appear.
##### Method 2: If the targeted appointment is within the last or next few days
1. Navigate to the home view (or don't move after launching the app)
2. Use the purple 'PREV' or 'NEXT' buttons to navigate to the day of the targeted appointment.
3. Find the appointment in the 'APPOINTMENTS' table which has all the appointments for the displayed date at the top of the home page.
4. Double Click the row entry to open the appointment details.
##### Method 3: If the targeted appointment is not within the last or next few days
1. Navigate to the calendar page by pressing 'CALENDAR' on the top nav bar.
2. Navigate to the month that the appointment is in using the left and right arrows beside the month name.
3. Select the day of the targeted appointment by clicking it.
4. Find the targeted appointment in the table.
5. Open the appointment details by Double Clicking the appointment row.
##### Method 4: Finding a specific client or doctors appointment
1. Navigate to the desired page using the top nav bar ('CLIENTS' for if looking for a client and 'DOCTORS' if looking for a doctor)
2. Either use the search bar to search for the client/doctor by name or scroll through the list of doctors/clients to find your targeted client/doctor.
3. Click on the client/doctor to open the details for that Client/Doctor.
4. Click on the 'APPOINTMENTS' button near the center of the popup.
5. Either scroll through or search through the list of appointments by date to find the targeted appointment
6. Click the targeted appointment to open the appointment details.
#### Reschedule An Appointment
1. Use any of the 4 methods above to open the appointment details for the targeted appointment.
2. Press the blue 'RESCHEDULE' button near the middle of the screen, this will take you to the second part of add appointment.
3. If you want to change the duration or reason for visit select the new duration and reason for visit by clicking on it.
4. If you do not want to change the duration or reason for visit either select the same one as before, or just press 'NEXT' to keep the old reason and duration.
5. Select the date and time you want to move this appointment to with using the same method as when you add an appointment described above. 
6. Click 'Confirm' and click 'Yes' in the confirmation popup to finialize the changes.
#### Change The Contact Details Of An Appointment
1. Use any of the 4 methods above to open the appointment details for the targeted appointment.
2. CLick the purple 'EDIT' button to open the edit popup.
3. Change either the appointment email, phone number, or both.
4. Click the 'SAVE' button and press 'Yes' in the confirmation popup to save your changes to the appointment.
#### Change Other Details Of An Appointment
1. Navigate to the 'CLIENTS' page using the top nav bar
2. Find the client that the targeted appointment belongs to, either with the search bar or by scrolling through the list
3. Click on the client to open the clients details
4. Click the 'EDIT' button to enter the edit client popup.
5. Make any of the desired changes to the clients fields.
6. Click the 'SAVE' button and click 'YES' in the confirmation popup to save the changes to the client and all appointments tied to the client.
#### Delete An Appointment
1. Use any of the 4 methods above to open the appointment details for the targeted appointment.
2. Click the purple 'EDIT' button to open the edit popup
3. Click the red 'DELETE' button in the top left of the window
4. Click the gray 'YES' button in the confirmation popup to delete the appointment
#### Find A Completed Appointment
Two Methods:
##### Method 1: Use the home page/Calendar page
1. Find the old appointment through the home page or calendar page as explained above. 
##### Method 2: Use the History page
1. Navigate to the 'HISOTRY' page using the top navbar.
2. Search the history page using either the clients name or simply scrolling through the list until you find your desired appointment
#### Find A Deleted/Canceled Appointment
1. Navigate to the 'HISOTRY' page using the top navbar.
2. Search the history page using either the clients name or simply scrolling through the list until you find your desired appointment
#### View A Clients Details
1. Navigate to the 'CLIENTS' page using the top navbar
2. Using either the search bar to search by name or simply scrolling through to find the targeted client
3. Click on the client to open the client details
#### Edit A Clients Details
1. Navigate to the 'CLIENTS' page using the top navbar
2. Using either the search bar to search by name or simply scrolling through to find the targeted client
3. Click on the client to open the client details
4. Click on the purple 'EDIT' button to enter the edit popup
5. Edit any of the desired fields belonging to the client.
6. Click 'SAVE' and press 'YES' in the confirmation popup to save the changes
#### Delete A Client
1. Navigate to the 'CLIENTS' page using the top navbar
2. Using either the search bar to search by name or simply scrolling through to find the targeted client
3. Click on the client to open the client details
4. Click on the purple 'EDIT' button to enter the edit popup
5. Click the red 'DELETE' button in the top left of the edit popup
6. Click the gray 'YES' in the confirmation popup to delete the client.
#### View A Doctors Details
1. Navigate to the 'DOCTORS' page using the top navbar
2. Using either the search bar to search by name or simply scrolling through to find the targeted doctor
3. Click on the doctor to open the doctor details
#### Edit A Doctors Details
1. Navigate to the 'DOCTORS' page using the top navbar
2. Using either the search bar to search by name or simply scrolling through to find the targeted client
3. Click on the client to open the doctor details
4. Click on the purple 'EDIT' button to enter the edit popup
5. Edit any of the desired fields belonging to the doctor.
6. Click 'SAVE' and press 'YES' in the confirmation popup to save the changes
#### Delete A Doctor
1. Navigate to the 'DOCTORS' page using the top navbar
2. Using either the search bar to search by name or simply scrolling through to find the targeted doctor
3. Click on the client to open the doctor details
4. Click on the purple 'EDIT' button to enter the edit popup
5. Click the red 'DELETE' button in the top left of the edit popup
6. Click the gray 'YES' in the confirmation popup to delete the doctor.
#### Logging In/Out
1. Navigate to the 'ACCOUNT' page using the top nav bar
2. Click your profile out of the profiles listed
3. Enter your pin in the pin text box below the profiles
4. Press the 'ENTER' key to enter the password
5. The account page should now display your details and all activity on the app while logged can be tracked
6. To logout press the red 'LOG OUT' button below your account details on the account page
#### Completing A Task In The ToDo/Notes List
1. Navigate to the 'HOME' page using the nav bar
2. Check the check box beside the list item that is complete
#### Adding A Task In The ToDo/Notes List
1. Navigate to the 'HOME' page using the nav bar
2. Type what you want to add into the text box below either the ToDo or Notices list (depending on which one you want to add to)
3. Once you are done typing Click the 'Add' button to add it to the list
#### Deleting A Task In The ToDo/Notes List
1. Navigate to the 'HOME' page using the nav bar
2. Click the 'X' on the right side of whichever list item you want to remove 
