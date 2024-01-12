import { Descriptions, DescriptionsProps } from "antd";
import { SocialState } from "../Utils/Enums";
import moment from "moment";
import { Patient } from "../interfaces";

type prop = {
  patient: Patient;
};

const PatientDescription = ({ patient }: prop) => {
  const descriptionItems: DescriptionsProps["items"] = [
    {
      key: "1",
      label: "اسم المريض",
      children: patient?.fullNameArabic,
    },
    {
      key: "2",
      label: "تاريخ الميلاد",
      children: moment(patient?.birthDate).format("DD-MM-YYYY"),
    },
    {
      key: "3",
      label: "الجنسية",
      children: patient?.nationality,
    },
    {
      key: "4",
      label: "Patient Name",
      children: patient?.fullNameEnglish,
    },
    {
      key: "5",
      label: "العنوان",
      children: patient?.contactInfo?.address,
    },
    {
      key: "6",
      label: "المدينة",
      children: patient?.contactInfo?.city,
    },
    {
      key: "7",
      label: "الجنس",
      children: patient?.gender == "0" ? "ذكر" : "انثى",
    },
    {
      key: "8",
      label: "الحالة الاجتماعية",
      children: SocialState[patient?.socialState ?? 0],
    },
    {
      key: "9",
      label: "الديانة",
      children: patient?.religion,
    },
    {
      key: "10",
      label: "رقم الهوية",
      children: patient?.nationalId,
    },
    {
      key: "11",
      label: "الوظيفة",
      children: patient?.job,
    },
    {
      key: "12",
      label: "رقم الهاتف",
      children: patient?.contactInfo?.phone1,
    },
    {
      key: "13",
      label: "رقم الهاتف 2",
      children: patient?.contactInfo?.phone2 ?? "لا يوجد",
    },
    {
      key: "14",
      label: "المحمول",
      children: patient?.contactInfo?.mobilePhone ?? "لا يوجد",
    },
    {
      key: "15",
      label: "البريد الالكتروني",
      children: patient?.contactInfo?.email ?? "لا يوجد",
    },
  ];

  return <Descriptions bordered items={descriptionItems} />;
};

export default PatientDescription;
