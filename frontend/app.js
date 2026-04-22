// URL base de tu API (¡Asegurate de que el puerto coincida con tu Visual Studio!)
const API_BASE_URL = "http://localhost:5041/api/v1"; 

console.log("Intentando conectar con el Backend...");

// Usamos Fetch para pegarle al endpoint del catálogo
fetch(`${API_BASE_URL}/events`)
    .then(response => {
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        return response.json();
    })
    .then(data => {
        console.log("¡ÉXITO! Los eventos llegaron:", data);
    })
    .catch(error => {
        console.error("¡EXPLOSIÓN! Falló la conexión:", error);
    });