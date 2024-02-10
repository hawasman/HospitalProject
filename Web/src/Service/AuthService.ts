import { useContext } from "react";
import { AuthContext } from "../Provider/AuthProvider";
import { AppUser, AuthToken, User } from "../interfaces";
import { axiosInstance } from "./Apis";

const loginURL = "/login";
const userURL = "/user";

export async function login(data?: AppUser) {
  return await axiosInstance.post<AuthToken>(loginURL, data);
}

export async function getUser() {
  return await axiosInstance.get<User>(userURL);
}

export const useAuth = () => {
  return useContext(AuthContext);
};
