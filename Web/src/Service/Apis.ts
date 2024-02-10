import axios from "axios";

const baseURL = "http://localhost:5180/"

export const axiosInstance = axios.create({baseURL:baseURL});

