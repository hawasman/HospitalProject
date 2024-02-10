import { Button, ConfigProvider, Flex, Layout, theme } from "antd";
import Sidebar from "./components/Sidebar";
import { Navigate, Outlet, useNavigate } from "react-router-dom";
import type { Locale } from "antd/es/locale";
import enUS from "antd/locale/en_US";
import ar_EG from "antd/locale/ar_EG";
import { useState } from "react";
import { DirectionType } from "antd/es/config-provider";
import "./Locale/i18n";
import { useTranslation } from "react-i18next";
import { getUser, useAuth } from "./Service/AuthService";

const { Header, Content, Footer } = Layout;

const App = () => {
  const { token, clearToken, user, setUser } = useAuth();
  const navigate = useNavigate();
  const [locale, setLocale] = useState<Locale>(ar_EG);
  const [direction, setDirection] = useState<DirectionType>("rtl");
  const { t, i18n } = useTranslation();

  const changeLocale = () => {
    if (locale == ar_EG) {
      setLocale(enUS);
      setDirection("ltr");
      i18n.changeLanguage("en");
      return;
    }

    setLocale(ar_EG);
    setDirection("rtl");
    i18n.changeLanguage("ar");
  };

  const {
    token: { colorBgContainer, borderRadiusLG },
  } = theme.useToken();

  const HeaderStyle = { background: colorBgContainer };
  const ContentStyle = {
    padding: 24,
    minHeight: 360,
    height: "100%",
    background: colorBgContainer,
    borderRadius: borderRadiusLG,
  };

  const handleLogin = async () => {
    if (token) {
      clearToken();
      navigate("/", { replace: true });
    }
  };

  if (token && !user) {
    getUser().then((res) => {
      if (!res) {
        return;
      }
      setUser(JSON.stringify(res.data));
    });
  }

  if (!token) {
    // If not authenticated, redirect to the login page
    return <Navigate to="/signin" />;
  }
  return (
    <>
      <ConfigProvider direction={direction} locale={locale}>
        <Layout style={{ minHeight: "100vh" }}>
          <Sidebar />
          <Layout>
            <Header style={HeaderStyle}>
              <Flex justify="space-between">
                <p>{t("app-name")}</p>
                <div>
                  <Button type="text" onClick={changeLocale}>
                    {locale == ar_EG ? "English" : "عربي"}
                  </Button>
                  <Button type="text" onClick={handleLogin}>
                    {token ? t("form.logout") : t("form.login")}
                  </Button>
                </div>
              </Flex>
            </Header>
            <Content style={{ margin: "24px 16px 0" }}>
              <div style={ContentStyle}>
                <Outlet />
              </div>
            </Content>
            <Footer style={{ textAlign: "center" }}>
              Hospital Project ©{new Date().getFullYear()}
            </Footer>
          </Layout>
        </Layout>
      </ConfigProvider>
    </>
  );
};

export default App;
