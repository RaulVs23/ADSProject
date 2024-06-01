import { environment } from "../../environments/environment.development";

export const endpoints = {
    agregarEstudiante: environment.serverURL
    .concat("api/Estudiantes/agregarEstudiantes"),
    actualizarEstudiante: environment.serverURL
    .concat("api/Estudiantes/actualizarEstudiante/{idEstudiante}"),
    eliminarEstudiante: environment.serverURL
    .concat("api/Estudiantes/eliminarEstudiante/{idEstudiante}"),
    obtenerEstudiantePorID: environment.serverURL
    .concat("api/Estudiantes/obtenerEstudiantePorID/{idEstudiante}"),
    obtenerEstudiante: environment.serverURL
    .concat("api/Estudiantes/obtenerEstudiantes") 
}