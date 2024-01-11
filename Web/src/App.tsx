import { Layout, theme } from "antd";
import Sidebar from "./components/Sidebar";
import { Outlet } from "react-router-dom";

const { Header, Content, Footer } = Layout;

const App = () => {
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
  return (
    <>
      <Layout style={{ minHeight: '100vh' }}>
        <Sidebar />
        <Layout>
          <Header style={HeaderStyle} >
            تطبيق ادارة المستشفى
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
    </>
  );
};

export default App;
