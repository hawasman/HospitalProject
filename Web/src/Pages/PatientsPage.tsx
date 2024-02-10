import { useState } from "react";
import type { TableProps } from "antd";
import { Button, Modal, Table, Tooltip } from "antd";
import type { ColumnsType, SorterResult } from "antd/es/table/interface";
import { InfoOutlined, PlusOutlined } from "@ant-design/icons";
import { Patient } from "../interfaces";
import { useNavigate } from "react-router-dom";
import { Gender, SocialState } from "../Utils/Enums";
import { useQuery } from "@tanstack/react-query";
import { getPatients } from "../Service/PatientService";
import PatientCreatePage from "./Patients/PatientCreatePage";
import { useTranslation } from "react-i18next";
import { DataTable } from "@/components/DataTable/data-table";
import { patientColumns } from "@/components/DataTable/columns";
import moment from 'moment';

const PatientsPage = () => {
  const { isPending, isError, data } = useQuery({
    queryKey: ["patients"],
    queryFn: getPatients,
    initialData: []
  });
  const navigate = useNavigate();

  const [sortedInfo, setSortedInfo] = useState<SorterResult<Patient>>({});
  const [isNew, setIsNew] = useState(false);
  const { t } = useTranslation();

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


  const columns: ColumnsType<Patient> = [
    {
      title: t("form.name"),
      dataIndex: "fullNameArabic",
      key: "fullNameArabic",
      sorter: (a, b) => a.fullNameArabic.length - b.fullNameArabic.length,
      sortOrder:
        sortedInfo.columnKey === "fullNameArabic" ? sortedInfo.order : null,
      ellipsis: true,
    },
    {
      title: t("form.gender"),
      dataIndex: "gender",
      key: "gender",
      render: (value: Gender) =>
        Gender[value] == "ذكر" ? t("gender.male") : t("gender.female"),
    },
    {
      title: t("form.nationality"),
      dataIndex: "nationality",
      key: "nationality",
      sorter: (a, b) => a.nationality.length - b.nationality.length,
      sortOrder:
        sortedInfo.columnKey === "nationality" ? sortedInfo.order : null,
      ellipsis: true,
    },
    {
      title: t("form.birthDate"),
      dataIndex: "birthDate",
      key: "birthDate",
      sorter: (a, b) => moment(a.birthDate).unix() - moment(b.birthDate).unix(),
      sortOrder: sortedInfo.columnKey === "birthDate" ? sortedInfo.order : null,
      render: (date: string) => moment(date).format("DD-MM-YYYY"),
      ellipsis: true,
    },
    {
      title: t("form.socialState"),
      dataIndex: "socialState",
      key: "socialState",
      render: (value) => {
        switch (SocialState[value]) {
          case "غير محدد":
            return t("socialState.undefined");
          case "متزوج":
            return t("socialState.married");
          case "اعزب":
            return t("socialState.single");
          case "مطلق":
            return t("socialState.divorced");
          case "ارملة":
            return t("socialState.widow");
          default:
            return t("socialState.undefined");
        }
      },
    },
    {
      title: t("form.religion"),
      dataIndex: "religion",
      key: "religion",
    },
    {
      title: t("form.nationalId"),
      dataIndex: "nationalId",
      key: "nationalId",
      sorter: (a, b) => a.nationalId.length - b.nationalId.length,
      sortOrder:
        sortedInfo.columnKey === "nationalId" ? sortedInfo.order : null,
      ellipsis: true,
    },
    {
      title: t("form.activeField"),
      dataIndex: "activeField",
      key: "activeField",
      ellipsis: true,
      render: (value: boolean) =>
        value ? t("form.active") : t("form.notActive"),
    },
    {
      title: "",
      dataIndex: "id",
      key: "x",
      render: (value) => {
        return (
          <>
            <Tooltip title={t("form.patientInfo")}>
              <Button
                onClick={() => handleView(value)}
                shape="circle"
                icon={<InfoOutlined />}
              />
            </Tooltip>
          </>
        );
      },
    },
  ];

  if (isError) {
    return <span>حدث خطاء اثناء تحميل البيانات</span>;
  }

  return (
    <>
      <Modal
        title={t("form.newPatient")}
        width="calc(100% - 500px)"
        centered
        open={isNew}
        onOk={() => setIsNew(false)}
        onCancel={() => setIsNew(false)}
      >
        <PatientCreatePage />
      </Modal>
      <div className="flex justify-between">
        <h2>{t("patientList")}</h2>
        <div>
          <Tooltip title={t("form.newPatient")}>
            <Button
              className="btn"
              onClick={() => setIsNew(true)}
              type="default"
              icon={<PlusOutlined />}
            />
          </Tooltip>
        </div>
      </div>
      <br />
      {/* <Table
        loading={isPending}
        columns={columns}
        dataSource={data}
        onChange={handleChange}
      /> */}
      <DataTable columns={patientColumns} data={data} />
    </>
  );
};

export default PatientsPage;
