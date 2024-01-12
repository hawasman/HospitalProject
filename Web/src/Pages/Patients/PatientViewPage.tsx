import { Divider } from "antd";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { MedicalFile, Patient } from "../../interfaces";
import axios from "axios";
import MedicalFileView from "../../components/MedicalFileView";
import PatientDescription from "../../components/PatientDescription";

const PatientViewPage = () => {
  const { id } = useParams();
  const [patient, setPatient] = useState<Patient>();
  const [patientFile, setPatientFile] = useState<MedicalFile>();

  useEffect(() => {
    axios
      .get(`https://localhost:7197/api/Patients/${id}`)
      .then((res) => setPatient(res.data));
    setPatientFile({
      id: 1,
      updatedAt: "string",
      createdAt: "string",
      userId: 1,
      activeField: true,
      patientId: patient!.id,
      patient: patient!,
      bloodType: "B+",
      bloodPressure: "90",
      heatDgree: 32,
      pulseRate: 23,
      sugarLevel: 44,
      weight: 80,
      hieght: 145,
      allergies: [],
      notes: "string",
      treatmentHistory: undefined,
    });
  }, [id,patient]);

  return (
    <>
      <Divider>{`معلومات المريض: ${id} / ${
        patient?.activeField == true ? "نشط" : "غير نشط"
      }`}</Divider>

      <PatientDescription patient={patient!} />

      <Divider>الملف الطبي</Divider>

      <MedicalFileView patientFile={patientFile!} />
    </>
  );
};

export default PatientViewPage;
