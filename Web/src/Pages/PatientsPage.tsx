import {useEffect, useState} from "react";
import type { TableProps } from "antd";
import { Button, Space, Table } from "antd";
import type {
  ColumnsType,
  // FilterValue,
  SorterResult,
} from "antd/es/table/interface";
import { Patient } from "../interfaces";
import moment from "moment";
import axios from "axios";

// const data: Patient[] = [
//   {
//     id: 1,
//     fullNameArabic: "محمد الطيب",
//     gender: "ذكر",
//     nationality: "سوداني",
//     birthDate: new Date(),
//     socialState: "متزوج",
//     religion: "مسلم",
//     nationalId: "asdasdasf",
//     activeField: true,
//   },
//   {
//     id: 2,
//     fullNameArabic: "خالد علي",
//     gender: "ذكر",
//     nationality: "سعودي",
//     birthDate: new Date(),
//     socialState: "اعزب",
//     religion: "مسلم",
//     nationalId: "23424124124",
//     activeField: false,
//   },
//   {
//     id: 3,
//     fullNameArabic: "فاطمة صبر",
//     gender: "انثئ",
//     nationality: "مصر",
//     birthDate: new Date(),
//     socialState: "اعزب",
//     religion: "مسلم",
//     nationalId: "90408673",
//     activeField: true,
//   },
//   {
//     id: 4,
//     fullNameArabic: "بكرام خان",
//     gender: "ذكر",
//     nationality: "الهند",
//     birthDate: new Date(),
//     socialState: "اعزب",
//     religion: "مسلم",
//     nationalId: "9947625555",
//     activeField: true,
//   },
// ];

const PatientsPage = () => {
  
  const [data , setData] = useState<Patient[]>([]);
  
  useEffect(() => {
    axios.get<Patient[]>("https://localhost:7197/api/Patients").then((res) => setData(res.data))
  })
  
  const [sortedInfo, setSortedInfo] = useState<SorterResult<Patient>>({});

  const handleChange: TableProps<Patient>["onChange"] = (
    pagination,
    filters,
    sorter
  ) => {
    console.log("Various parameters", pagination, filters, sorter);
    // setFilteredInfo(filters);
    setSortedInfo(sorter as SorterResult<Patient>);
  };

  const clearFilters = () => {
    // setFilteredInfo({});
  };

  const clearAll = () => {
    // setFilteredInfo({});
    setSortedInfo({});
  };

  const setAgeSort = () => {
    setSortedInfo({
      order: "descend",
      columnKey: "gender",
    });
  };

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
      sorter: (a, b) => a.gender.length - b.gender.length,
      sortOrder: sortedInfo.columnKey === "gender" ? sortedInfo.order : null,
      ellipsis: true,
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
      render: ((date:string) => moment(date).format("DD-MM-YYYY")),
      ellipsis: true,
    },
    {
      title: "الحالة الاجتماعية",
      dataIndex: "socialState",
      key: "socialState",
      sorter: (a, b) => a.socialState.length - b.socialState.length,
      sortOrder:
        sortedInfo.columnKey === "socialState" ? sortedInfo.order : null,
      ellipsis: true,
    },
    {
      title: "الديانة",
      dataIndex: "religion",
      key: "religion",
      sorter: (a, b) => a.religion.length - b.religion.length,
      sortOrder:
        sortedInfo.columnKey === "religion" ? sortedInfo.order : null,
      ellipsis: true,
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
      render: (value: boolean) => value == true ? "نشط" : "غير نشط",
    },
  ];
  return (
    <>
      <Space style={{ marginBottom: 16 }}>
        <Button onClick={setAgeSort}>Sort age</Button>
        <Button onClick={clearFilters}>Clear filters</Button>
        <Button onClick={clearAll}>Clear filters and sorters</Button>
      </Space>
      <Table columns={columns} dataSource={data} onChange={handleChange} />
    </>
  );
};

export default PatientsPage;
