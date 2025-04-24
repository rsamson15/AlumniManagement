import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [users, setUsers] = useState();

    useEffect(() => {
        populateUsers();
    }, []);

    const contents = users === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tableLabel">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th>Phone Number</th>
                    <th>Current Job Title</th>
                    <th>Organization</th>
                    <th>Profile Image</th>
                    <th>Graduation Year</th>
                    <th>Graduation Semester</th>
                    <th>GitHub Profile</th>
                    <th>LinkedIn Profile</th>
                    <th>Looking for Mentor</th>
                    <th>User Type</th>

                </tr>
            </thead>
            <tbody>
                {users.map(user => (
                    <tr key={user.id}>
                        <td>{user.firstName}</td>
                        <td>{user.lastName}</td>
                        <td>{user.email}</td>
                        <td>{user.phoneNumber}</td>
                        <td>{user.currentJobTitle}</td>
                        <td>{user.organization}</td>
                        <td>{user.profileImage}</td>
                        <td>{user.graduationYear}</td>
                        <td>{user.graduationSemester}</td>
                        <td>{user.githubProfile}</td>
                        <td>{user.linkedInProfile}</td>
                        <td>{user.lookingForMentor ? 'Yes' : 'No'}</td>
                        <td>{user.userType}</td>
                    </tr>
                ))}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tableLabel">Weather user</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
        </div>
    );
    
    async function populateUsers() {
        const response = await fetch('https://localhost:7084/api/users');
        if (response.ok) {
            const data = await response.json();
            console.log(data);
            setUsers(data);
        }
    }
}

export default App;