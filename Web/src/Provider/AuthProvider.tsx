import {
  PropsWithChildren,
  createContext,
  useEffect,
  useMemo,
  useState,
} from "react";
import { axiosInstance } from "@/Service/Apis";

type AuthContextProps = {
  token: string | null;
  setToken: (newToken: string | null) => void;
  clearToken: () => void;
};

export const AuthContext = createContext<AuthContextProps>({
  token: null,
  setToken: () => {},
  clearToken: () => {},
});

export const AuthProvider = ({ children }: PropsWithChildren) => {
  // State to hold the authentication token
  const [token, setToken_] = useState(localStorage.getItem("auth"));

  // Function to set the authentication token
  const setToken = (newToken: string | null) => {
    setToken_(newToken);
  };

  const clearToken = () => {
    setToken_(null);
  }

  useEffect(() => {
    if (token) {
      axiosInstance.defaults.headers.common["Authorization"] =
        "Bearer " + token;
      localStorage.setItem("auth", token);
    } else {
      delete axiosInstance.defaults.headers.common["Authorization"];
      localStorage.removeItem("auth");
    }
  }, [token]);

  // Memoized value of the authentication context
  const contextValue = useMemo(
    () => ({
      token,
      setToken,
      clearToken
    }),
    [token]
  );

  // Provide the authentication context to the children components
  return (
    <AuthContext.Provider value={contextValue}>{children}</AuthContext.Provider>
  );
};
