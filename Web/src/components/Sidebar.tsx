import { Menu, MenuProps } from "antd";
import {
  WalletOutlined,
  TeamOutlined,
  SettingOutlined,
  HomeOutlined,
  AreaChartOutlined,
} from "@ant-design/icons";
import Sider from "antd/es/layout/Sider";
import { useNavigate } from "react-router-dom";
import { useState } from "react";
import { useTranslation } from "react-i18next";

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

const Sidebar = () => {
  const [collapsed, setCollapsed] = useState(false);
  const { t } = useTranslation();
  const navigate = useNavigate();
  const onClick: MenuProps["onClick"] = (e) => {
    navigate(e.key);
  };

  const items: MenuItem[] = [
    getItem(t("sidebar.home"),"home", <HomeOutlined />),
    getItem(t("sidebar.patients"), "sub1", <TeamOutlined />, [
      getItem(t("sidebar.patientList"), "patients"),
    ]),

    getItem(t("sidebar.finance"), "sub2", <WalletOutlined />, [
      getItem("Option 5", "5"),
      getItem("Option 6", "6"),
    ]),

    getItem(t("sidebar.report"), "sub3", <AreaChartOutlined />, [
      getItem("Option 9", "9"),
    ]),
    getItem(t("sidebar.settings"), "settings", <SettingOutlined />),
  ];

  return (
    <>
      <Sider
        collapsible
        collapsed={collapsed}
        onCollapse={(value) => setCollapsed(value)}
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
