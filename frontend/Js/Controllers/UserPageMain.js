import { getUserIdFromToken, logout } from '../Services/AuthService.js';
import { initPage } from './CatalogController.js';
import { setupAdminEvents } from './AdminController.js';
import { setupCartEvents } from './CartController.js';

// ==========================================
// 1. Identidad y Redirección
// ==========================================
const CURRENT_USER_ID = getUserIdFromToken();
if (!CURRENT_USER_ID) {
    window.location.href = 'Pages/login.html';
}

const userName = sessionStorage.getItem('user_name');
const nameDisplay = document.getElementById('user-name-display');
if (userName && nameDisplay) {
    nameDisplay.innerText = `Usuario: ${userName}`;
}

const userRole = sessionStorage.getItem('user_role');
if (userRole === 'Admin') {
    document.getElementById('admin-controls').classList.remove('d-none');
}

// ==========================================
// 2. Eventos Globales de Navegación "Atrás"
// ==========================================
const viewCatalog = document.getElementById('view-catalog');
const viewSectors = document.getElementById('view-sectors');
const viewSeats = document.getElementById('view-seats');

document.getElementById('btn-back-catalog').addEventListener('click', () => {
    viewSectors.classList.add('d-none');
    viewCatalog.classList.remove('d-none');
});

document.getElementById('btn-back-sectors').addEventListener('click', () => {
    viewSeats.classList.add('d-none');
    viewSectors.classList.remove('d-none');
});

// ==========================================
// 3. Cierre de Sesión Seguro
// ==========================================
document.getElementById('btn-logout').addEventListener('click', () => {
    Swal.fire({
        title: '¿Cerrar sesión?',
        text: "Tendrás que volver a ingresar tus credenciales.",
        icon: 'warning', showCancelButton: true, background: 'var(--card-bg)', color: 'var(--text-main)',
        confirmButtonColor: 'var(--danger)', cancelButtonColor: 'var(--border-color)',
        confirmButtonText: 'Sí, salir', cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            logout();
        }
    });
});

// ==========================================
// 4. INICIALIZACIÓN DE LA APLICACIÓN
// ==========================================
setupAdminEvents();
setupCartEvents();
initPage();