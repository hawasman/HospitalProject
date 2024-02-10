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
  user: string | null;
  setToken: (newToken: string | null) => void;
  clearToken: () => void;
  setUser: (User: string | null) => void;
};

export const AuthContext = createContext<AuthContextProps>({
  token: null,
  user: null,
  setToken: () => {},
  clearToken: () => {},
  setUser: () => {},
});

export const AuthProvider = ({ children }: PropsWithChildren) => {
  const [user, setUser_] = useState(localStorage.getItem("user"));
  // State to hold the authentication token
  const [token, setToken_] = useState(localStorage.getItem("auth"));

  // Function to set the authentication token
  const setToken = (newToken: string | null) => {
    setToken_(newToken);
  };
  const setUser= (User: string | null) => {
    setUser_(User);
  };

  const clearToken = () => {
    setToken_(null);
  };

  useEffect(() => {
    if (token) {
      const accessToken = JSON.parse(token).accessToken;
      axiosInstance.defaults.headers.common["Authorization"] =
        "Bearer " + accessToken;
      localStorage.setItem("auth", token);
    } else {
      delete axiosInstance.defaults.headers.common["Authorization"];
      localStorage.removeItem("auth");
    }
  }, [token]);

  useEffect(() => {
    if (user) {
      const tenant = JSON.parse(user).tenantId;
      axiosInstance.defaults.headers.common["tenant"] = tenant;
      localStorage.setItem("user", user);
    } else {
      localStorage.removeItem("user");
    }
  }, [user]);
   
  // Memoized value of the authentication context
  const contextValue = useMemo(
    () => ({
      token,
      user,
      setToken,
      clearToken,
      setUser,
    }),
    [token, user]
  );

  // Provide the authentication context to the children components
  return (
    <AuthContext.Provider value={contextValue}>{children}</AuthContext.Provider>
  );
};
