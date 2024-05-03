// script.js
document.getElementById('registrationForm').addEventListener('submit', function(event) {
    event.preventDefault();
    
    const formData = {
        name: document.getElementById('name').value,
        specialty: document.getElementById('specialty').value,
        email: document.getElementById('email').value,
        phone: document.getElementById('phone').value,
        address: document.getElementById('address').value,
        experience: document.getElementById('experience').value
    };
    
    console.log("Form Data:", formData);
    alert('Registration Successful!');
    // Here you would normally send the formData to the server
});