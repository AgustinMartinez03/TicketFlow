import { loginApi } from '../Services/AuthService.js';

const togglePasswordBtn = document.getElementById('togglePassword');
const passwordInput = document.getElementById('password');
const toggleIcon = document.getElementById('toggleIcon');

if (togglePasswordBtn && passwordInput && toggleIcon) {
    togglePasswordBtn.addEventListener('click', () => {
        const type = passwordInput.getAttribute('type') === 'password' ? 'text' : 'password';
        passwordInput.setAttribute('type', type);
        
        if (type === 'password') {
            toggleIcon.classList.remove('bi-eye-slash');
            toggleIcon.classList.add('bi-eye');
        } else {
            toggleIcon.classList.remove('bi-eye');
            toggleIcon.classList.add('bi-eye-slash');
        }
    });
}

document.getElementById('login-form').addEventListener('submit', async (e) => {
    e.preventDefault();

    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;

    try {
        Swal.fire({
            title: 'Iniciando sesión...',
            background: 'var(--card-bg)', 
            color: 'var(--text-main)',
            allowOutsideClick: false,
            didOpen: () => { Swal.showLoading(); }
        });

        const data = await loginApi(email, password);

        sessionStorage.setItem('jwt_token', data.token);
        sessionStorage.setItem('user_name', data.name);
        sessionStorage.setItem('user_role', data.role);

        Swal.close();
        
        window.location.href = '../index.html';

    } catch (error) {
        Swal.fire({
            icon: 'error',
            title: 'Error de acceso',
            text: error.message,
            background: 'var(--card-bg)', 
            color: 'var(--text-main)', 
            confirmButtonColor: 'var(--danger)'
        });
    }
});