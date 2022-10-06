import axios from "axios";

const BASE_URL = process.env.REACT_APP_URLBACKEND;

const AppInstance = axios.create({ baseURL: BASE_URL });

// apInstance.interceptors.request.use((request) => {
//   const token = sessionStorage.getItem("accesstoken");
//   const tokenL = localStorage.getItem("accesstoken");
//   console.log("token de la sesión" + token + "y del local" + tokenL)
//   request.headers.common["accesstoken"] = "Bearer " + token;
//   return request;
// });

export default AppInstance;
