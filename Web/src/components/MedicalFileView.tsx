import { Descriptions, DescriptionsProps, Tabs, TabsProps } from "antd";
import { MedicalFile } from "../interfaces";
import PatientTreatments from "./PatientTreatments";
import PatientAttatchments from "./PatientAttatchments";

type prop = {
  patientFile: MedicalFile;
};

const MedicalFileView = ({ patientFile }: prop) => {
  const id = patientFile.id;

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

  const items: TabsProps["items"] = [
    {
      key: "1",
      label: "البيانات الاساسية",
      children: <Descriptions bordered items={descriptionItems} />,
    },
    {
      key: "2",
      label: "التاريخ الطبي",
      children: <PatientTreatments id={id} />,
    },
    {
      key: "3",
      label: "المستندات",
      children:<PatientAttatchments />
    },
  ];

  return <Tabs defaultActiveKey="1" items={items} />;
};

export default MedicalFileView;
