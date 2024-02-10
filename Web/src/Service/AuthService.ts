import { useContext } from "react";
import { AuthContext } from "../Provider/AuthProvider";
import { AppUser, AuthToken } from "../interfaces";
import { axiosInstance } from "./Apis";

const loginURL = "/login";

export async function login(data?: AppUser) {
  return await axiosInstance.post<AuthToken>(loginURL, data);
}

export const useAuth = () => {
  return useContext(AuthContext)
};