import { Menu, MenuProps } from "antd";
import {
  AppstoreOutlined,
  MailOutlined,
  SettingOutlined,
} from "@ant-design/icons";
import Sider from "antd/es/layout/Sider";
import { useNavigate } from "react-router-dom";

type MenuItem = Required<MenuProps>["items"][number];

function getItem(
  label: React.ReactNode,
  key?: React.Key | null,
  icon?: React.ReactNode,
  children?: MenuItem[],
  type?: "group"
): MenuItem {
  return {
    key,
    icon,
    children,
    label,
    type,
  } as MenuItem;
}

const items: MenuItem[] = [
  getItem("الرئيسية", "", <MailOutlined />),
  getItem("المرضى", "sub1", <MailOutlined />, [
    getItem("معلومات المريض", "patients"),
  ]),

  getItem("المالية", "sub2", <AppstoreOutlined />, [
    getItem("Option 5", "5"),
    getItem("Option 6", "6"),
  ]),

  getItem("التقارير", "sub3", <SettingOutlined />, [getItem("Option 9", "9")]),
];

const Sidebar = () => {
  const navigate = useNavigate();
  const onClick: MenuProps["onClick"] = (e) => {
    console.log("click ", e);
    navigate(e.key);
  };

  return (
    <>
      <Sider
        breakpoint="lg"
        collapsedWidth="0"
        onBreakpoint={(broken) => {
          console.log(broken);
        }}
        onCollapse={(collapsed, type) => {
          console.log(collapsed, type);
        }}
      >
        <Menu
          onClick={onClick}
          theme="dark"
          mode="inline"
          defaultSelectedKeys={["1"]}
          items={items}
        />
      </Sider>
    </>
  );
};

export default Sidebar;
