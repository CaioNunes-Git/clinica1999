// script.js
document.getElementById('patientRegistrationForm').addEventListener('submit', function(event) {
    event.preventDefault();
    
    const formData = {
        name: document.getElementById('patientName').value,
        dob: document.getElementById('patientDOB').value,
        email: document.getElementById('patientEmail').value,
        phone: document.getElementById('patientPhone').value,
        address: document.getElementById('patientAddress').value,
        medicalHistory: document.getElementById('medicalHistory').value
    };
    
    console.log("Patient Registration Data:", formData);
    alert('Patient Registration Successful!');
    // Here you would normally send the formData to the server
});