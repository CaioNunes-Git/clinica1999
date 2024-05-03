
function login() {
    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;
    // Dummy signIn function, replace with actual authentication
    if(username === 'user' && password === 'pass') {
      alert('Login Successful');
    } else {
      alert('Login Failed');
    }
  }
  