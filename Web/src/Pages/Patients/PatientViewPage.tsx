import { Divider, Spin } from "antd";
import { useParams } from "react-router-dom";
import MedicalFileView from "../../components/MedicalFileView";
import PatientDescription from "../../components/PatientDescription";
import { useQuery } from "@tanstack/react-query";
import {
  getPatientbyId,
} from "../../Service/PatientService";

const PatientViewPage = () => {
  const { id } = useParams();
  const patientQuery = useQuery({
    queryKey: ["patient", id],
    queryFn: () => getPatientbyId(parseInt(id!)),
  });
  // const patientFileQuery = useQuery({
  //   queryKey: ["patientFile", id],
  //   queryFn: () => getMedicalFileByPatientId(parseInt(id!)),
  // });

  return (
    <>
      <Divider>{`معلومات المريض: ${id} / ${
        patientQuery.data?.activeField == true ? "نشط" : "غير نشط"
      }`}</Divider>

      <PatientDescription patient={patientQuery.data!} />

      <Divider>الملف الطبي</Divider>

      { patientQuery.data?.medicalFile ? <MedicalFileView patientFile={patientQuery.data?.medicalFile} /> : null}

      <Spin spinning={patientQuery.isPending} fullscreen />
    </>
  );
};

export default PatientViewPage;
