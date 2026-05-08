const API_BASE_URL = 'https://localhost:7157/api/v1';

export async function loginApi(email, password) {
    const response = await fetch(`${API_BASE_URL}/Auth/login`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ email, password })
    });

    if (!response.ok) {
        const errorData = await response.json().catch(() => null);
        throw new Error(errorData?.message || "Email o contraseña incorrectos");
    }

    return await response.json();
}

export function getAuthToken() {
    return sessionStorage.getItem('jwt_token');
}

export function getUserIdFromToken() {
    const token = getAuthToken();
    if (!token) return null;
    try {
        const payload = JSON.parse(atob(token.split('.')[1]));
        return payload['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier'];
    } catch (e) {
        return null;
    }
}

export function logout() {
    sessionStorage.clear();
    window.location.href = 'Pages/login.html';
}