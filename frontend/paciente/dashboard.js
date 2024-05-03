
document.addEventListener('DOMContentLoaded', function() {
    const appointments = ['Dental Checkup', 'Routine Blood Test'];
    const prescriptions = ['Amoxicillin', 'Ibuprofen'];
    
    const appointmentsEl = document.getElementById('appointments');
    appointments.forEach((appointment) => {
        const p = document.createElement('p');
        p.innerHTML = appointment;
        appointmentsEl.appendChild(p);
    });

    const prescriptionsEl = document.getElementById('prescriptions');
    prescriptions.forEach((prescription) => {
        const p = document.createElement('p');
        p.innerHTML = prescription;
        prescriptionsEl.appendChild(p);
    });
});
