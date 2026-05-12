// Prueba de Estrés de Concurrencia - TicketFlow API

// NOTA: Verificar que el puerto coincida con el entorno de ejecución actual.
const apiUrl = "https://localhost:7157/api/v1/reservations"; 

// Reemplazar con un token JWT válido o utilizar sessionStorage si se ejecuta desde el navegador.
const TOKEN = sessionStorage.getItem('jwt_token') || "PEGAR_TOKEN_AQUI"; 

const payload = {
  userId: 1, // ID de usuario (Debe coincidir con el usuario autenticado en el token).
  seatId: "5686244A-0404-42C5-B3B4-A496A233D816" // ID de una butaca en estado 'Disponible'.
};

console.log("Iniciando prueba de carga de peticiones concurrentes...");

const requests = Array.from({ length: 10 }).map((_, index) => {
  return fetch(apiUrl, {
    method: "POST",
    headers: { 
        "Content-Type": "application/json",
        "Authorization": `Bearer ${TOKEN}`
    },
    body: JSON.stringify(payload)
  }).then(async response => {
      const data = await response.json().catch(() => ({}));
      return { status: response.status, data: data, requestNumber: index + 1 };
  });
});

Promise.all(requests).then(results => {
    let successCount = 0;
    let conflictCount = 0;

    results.forEach(res => {
        if (res.status === 200 || res.status === 201) {
            console.log(`✅ Petición ${res.requestNumber}: Reserva Exitosa (Status: ${res.status})`);
            successCount++;
        } else if (res.status === 409) {
            console.warn(`🛑 Petición ${res.requestNumber}: Conflicto de concurrencia interceptado (Status: ${res.status})`);
            conflictCount++;
        } else {
            console.error(`❌ Petición ${res.requestNumber}: Error inesperado (Status: ${res.status})`, res.data);
        }
    });

    console.log(`\n📊 RESUMEN DE LA PRUEBA:`);
    console.log(`Reservas Exitosas (Esperado: 1): ${successCount}`);
    console.log(`Conflictos 409 (Esperado: 9): ${conflictCount}`);
});