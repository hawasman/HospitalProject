import { useEffect, useState } from "react";
import type { TableProps } from "antd";
import { Button, Table, Tooltip } from "antd";
import type { ColumnsType, SorterResult } from "antd/es/table/interface";
import { InfoOutlined } from "@ant-design/icons";
import { Patient } from "../interfaces";
import moment from "moment";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import { Gender } from "../Utils/Enums";

const PatientsPage = () => {
  const [data, setData] = useState<Patient[]>([]);

  useEffect(() => {
    axios
      .get<Patient[]>("https://localhost:7197/api/Patients")
      .then((res) => setData(res.data));
  },[]);

  const [sortedInfo, setSortedInfo] = useState<SorterResult<Patient>>({});

  const handleChange: TableProps<Patient>["onChange"] = (
    pagination,
    filters,
    sorter
  ) => {
    console.log("Various parameters", pagination, filters, sorter);
    setSortedInfo(sorter as SorterResult<Patient>);
  };

  const handleView = (id: number) => {
    navigate(`${id}`);
  };

  const navigate = useNavigate();

  const columns: ColumnsType<Patient> = [
    {
      title: "الاسم",
      dataIndex: "fullNameArabic",
      key: "fullNameArabic",
      sorter: (a, b) => a.fullNameArabic.length - b.fullNameArabic.length,
      sortOrder:
        sortedInfo.columnKey === "fullNameArabic" ? sortedInfo.order : null,
      ellipsis: true,
    },
    {
      title: "الجنس",
      dataIndex: "gender",
      key: "gender",
      render: (value: Gender) => Gender[value],
      // sorter: (a, b) => a.gender.length - b.gender.length,
      // sortOrder: sortedInfo.columnKey === "gender" ? sortedInfo.order : null,
      // ellipsis: true,
    },
    {
      title: "الجنسية",
      dataIndex: "nationality",
      key: "nationality",
      sorter: (a, b) => a.nationality.length - b.nationality.length,
      sortOrder:
        sortedInfo.columnKey === "nationality" ? sortedInfo.order : null,
      ellipsis: true,
    },
    {
      title: "تاريخ الميلاد",
      dataIndex: "birthDate",
      key: "birthDate",
      sorter: (a, b) => moment(a.birthDate).unix() - moment(b.birthDate).unix(),
      sortOrder: sortedInfo.columnKey === "birthDate" ? sortedInfo.order : null,
      render: (date: string) => moment(date).format("DD-MM-YYYY"),
      ellipsis: true,
    },
    {
      title: "الحالة الاجتماعية",
      dataIndex: "socialState",
      key: "socialState",
      // sorter: (a, b) => a.socialState.length - b.socialState.length,
      // sortOrder:
      //   sortedInfo.columnKey === "socialState" ? sortedInfo.order : null,
      // ellipsis: true,
    },
    {
      title: "الديانة",
      dataIndex: "religion",
      key: "religion",
      // sorter: (a, b) => a.religion.length - b.religion.length,
      // sortOrder: sortedInfo.columnKey === "religion" ? sortedInfo.order : null,
      // ellipsis: true,
    },
    {
      title: "رقم الهوية",
      dataIndex: "nationalId",
      key: "nationalId",
      sorter: (a, b) => a.nationalId.length - b.nationalId.length,
      sortOrder:
        sortedInfo.columnKey === "nationalId" ? sortedInfo.order : null,
      ellipsis: true,
    },
    {
      title: "حالة الحساب",
      dataIndex: "activeField",
      key: "activeField",
      ellipsis: true,
      render: (value: boolean) => (value == true ? "نشط" : "غير نشط"),
    },
    {
      title: "",
      dataIndex: "id",
      key: "x",
      render: (value) => {
        return (
          <>
            <Tooltip title="معلوات المريض">
              <Button
                onClick={() => handleView(value)}
                type="primary"
                shape="circle"
                icon={<InfoOutlined />}
              />
            </Tooltip>
          </>
        );
      },
    },
  ];

  return (
    <>
      <Table columns={columns} dataSource={data} onChange={handleChange} />
    </>
  );
};

export default PatientsPage;
