import { loginApi } from '../Services/AuthService.js';

document.getElementById('login-form').addEventListener('submit', async (e) => {
    e.preventDefault();

    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;

    try {
        Swal.fire({
            title: 'Iniciando sesión...',
            background: '#1a1d24', color: '#ffffff',
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
            background: '#1a1d24', color: '#ffffff', confirmButtonColor: '#ef4444'
        });
    }
});