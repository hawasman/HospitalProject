import axios from "axios";

const baseURL = "https://localhost:7197/"

export const axiosInstance = axios.create({baseURL:baseURL});

