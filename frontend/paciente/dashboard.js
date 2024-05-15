document.addEventListener('DOMContentLoaded', function() {
    const axios = require('axios').default;
    
    axios.get('http://localhost:8080/funcionario')
    .then(function (response) {
        const funcionarios = response.data.content; 

        updateDashboard(funcionarios);
    })
    .catch(function (error) {
        console.error('Erro ao carregar dados do backend:', error);
    });
});

function updateDashboard(funcionarios) {
    const funcionariosEl = document.getElementById('funcionarios');
    funcionarios.forEach((funcionario) => {
        const p = document.createElement('p');
        p.textContent = funcionario.nome; 
        funcionariosEl.appendChild(p);
    });
}
