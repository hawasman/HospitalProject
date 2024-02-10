import { RouterProvider, createBrowserRouter } from "react-router-dom";
import App from "../App";
import HomePage from "../Pages/HomePage";
import PatientsPage from "../Pages/PatientsPage";
import ErrorPage from "../error-page";
import PatientViewPage from "../Pages/Patients/PatientViewPage";
import PatientCreatePage from "../Pages/Patients/PatientCreatePage";
import LoginPage from "../Pages/LoginPage";
import { useAuth } from "@/Service/AuthService";

const Routes = () => {
  const { token } = useAuth();

  const routesForPublic = [
    {
      path: "/service",
      element: <div>Service Page</div>,
    },
    {
      path: "/about-us",
      element: <div>About Us</div>,
    },
  ];
  
  const routesForAuthenticatedOnly = [
    {
      path: "/",
      element: <App />,
      errorElement: <ErrorPage />,
      children: [
        { path: "", element: <HomePage /> },
        { path: "patients", element: <PatientsPage /> },
        { path: "patients/new", element: <PatientCreatePage /> },
        { path: "patients/:id", element: <PatientViewPage /> },
      ],
    },
  ];

  const routesForNotAuthenticatedOnly = [
    { path: "signin", element: <LoginPage /> },
  ];

  const router = createBrowserRouter([
    ...routesForPublic,
    ...(!token ? routesForNotAuthenticatedOnly : []),
    ...routesForAuthenticatedOnly,
  ]);

  // Provide the router configuration using RouterProvider
  return <RouterProvider router={router} />;
};

export default Routes;