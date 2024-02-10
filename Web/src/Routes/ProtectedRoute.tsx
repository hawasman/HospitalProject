import { Outlet } from 'react-router-dom';


export const ProtectedRoute = () => {
  
    // If authenticated, render the child routes
    return <Outlet />;
  };