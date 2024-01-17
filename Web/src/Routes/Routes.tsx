import { createBrowserRouter } from "react-router-dom";
import App from "../App";
import HomePage from "../Pages/HomePage";
import PatientsPage from "../Pages/PatientsPage";
import ErrorPage from "../error-page";
import PatientViewPage from "../Pages/Patients/PatientViewPage";
import PatientCreatePage from "../Pages/Patients/PatientCreatePage";

export const router = createBrowserRouter([
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
]);