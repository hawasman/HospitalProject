import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import { ConfigProvider } from "antd";
import { RouterProvider } from "react-router-dom";
import { router } from "./Routes/Routes.tsx";

ReactDOM.createRoot(document.getElementById("root")!).render(
  <ConfigProvider direction="rtl">
    <React.StrictMode>
      <RouterProvider router={router} />
    </React.StrictMode>
  </ConfigProvider>
);
