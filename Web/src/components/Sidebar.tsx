import { Menu, MenuProps } from "antd";
import {
  WalletOutlined,
  TeamOutlined,
  SettingOutlined,
  HomeOutlined,
  AreaChartOutlined
} from "@ant-design/icons";
import Sider from "antd/es/layout/Sider";
import { useNavigate } from "react-router-dom";
import { useState } from "react";

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
  getItem("الرئيسية", "", <HomeOutlined />),
  getItem("المرضى", "sub1", <TeamOutlined />, [
    getItem("معلومات المريض", "patients"),
  ]),

  getItem("المالية", "sub2",<WalletOutlined />, [
    getItem("Option 5", "5"),
    getItem("Option 6", "6"),
  ]),

  getItem("التقارير", "sub3", <AreaChartOutlined />, [getItem("Option 9", "9")]),
  getItem("الاعدادات", "settings", <SettingOutlined />),
];

const Sidebar = () => {
  const [collapsed, setCollapsed] = useState(false);
  const navigate = useNavigate();
  const onClick: MenuProps["onClick"] = (e) => {
    navigate(e.key);
  };

  return (
    <>
      <Sider
       collapsible collapsed={collapsed} onCollapse={(value) => setCollapsed(value)}
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
