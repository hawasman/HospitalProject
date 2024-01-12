import axios from "axios";

const baseURL = "http://localhost:5180/api/"

export const axiosInstance = axios.create({baseURL:baseURL});

