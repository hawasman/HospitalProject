import { Descriptions, DescriptionsProps, Table, Tabs, TabsProps } from "antd";
import { MedicalFile, TreatmentHistory } from "../interfaces";
import { ColumnsType } from "antd/es/table";
import moment from "moment";
import { useQuery } from "@tanstack/react-query";
import { getTreatmentByMedicalFileId } from "../Service/PatientService";

type prop = {
  patientFile: MedicalFile;
};

const MedicalFileView = ({ patientFile }: prop) => {
  const id = patientFile.id;

  const treatmentQuery = useQuery({
    queryKey: ["treatmentHistory", id],
    queryFn: () => getTreatmentByMedicalFileId(id),
  });

  const descriptionItems: DescriptionsProps["items"] = [
    {
      key: "1",
      label: "فصيلة الدم",
      children: patientFile?.bloodType,
    },
    {
      key: "2",
      label: "ضغط الدم",
      children: patientFile?.bloodPressure,
    },
    {
      key: "3",
      label: "درجة الحرارة",
      children: patientFile?.heatDgree,
    },
    {
      key: "4",
      label: "النبض",
      children: patientFile?.pulseRate,
    },
    {
      key: "5",
      label: "السكر",
      children: patientFile?.sugarLevel,
    },
    {
      key: "6",
      label: "الوزن",
      children: patientFile?.weight,
    },
    {
      key: "7",
      label: "الطول",
      children: patientFile?.hieght,
    },
    {
      key: "8",
      label: "الملاحظات",
      children: patientFile?.notes,
    },
  ];

  const columns: ColumnsType<TreatmentHistory> = [
    {
      title: "رقم الطبيب",
      dataIndex: "doctorId",
      key: "doctorId",
    },
    {
      title: "رقم العيادة",
      dataIndex: "clinicid",
      key: "clinicid",
    },
    {
      title: "الاعراض",
      dataIndex: "symptoms",
      key: "symptoms",
    },
    {
      title: "النوع",
      dataIndex: "type",
      key: "type",
    },
    {
      title: "التاريخ",
      dataIndex: "createdAt",
      key: "createdAt",
      render: (e) => moment(e).format("DD-MM-YYYY"),
    },
  ];

  const items: TabsProps["items"] = [
    {
      key: "1",
      label: "البيانات الاساسية",
      children: <Descriptions bordered items={descriptionItems} />,
    },
    {
      key: "2",
      label: "التاريخ الطبي",
      children: treatmentQuery.isError ? (
        <h3 style={{ display: "block", textAlign: "center", padding: 70 }}>لا توجد بيانات</h3>
      ) : (
        <Table
          columns={columns}
          loading={treatmentQuery.isPending}
          dataSource={treatmentQuery.data}
        />
      ),
    },
    {
      key: "3",
      label: "المستندات",
      children: <h3 style={{ display: "block", textAlign: "center", padding: 70 }}>لا توجد بيانات</h3>,
    },
  ];

  return <Tabs defaultActiveKey="1" items={items} />;
};

export default MedicalFileView;
