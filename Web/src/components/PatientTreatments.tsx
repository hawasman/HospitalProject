import { Table } from "antd";
import { ColumnsType } from "antd/es/table";
import moment from "moment";
import { TreatmentHistory } from "../interfaces";
import { useQuery } from "@tanstack/react-query";
import { getTreatmentByMedicalFileId } from "../Service/PatientService";

type Prop = {
  id: number;
};

const PatientTreatments = ({ id }: Prop) => {
  const treatmentQuery = useQuery({
    queryKey: ["treatmentHistory", id],
    queryFn: () => getTreatmentByMedicalFileId(id),
  });

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

  return (
    <>
      {treatmentQuery.isError ? (
        <h3 style={{ display: "block", textAlign: "center", padding: 70 }}>
          لا توجد بيانات
        </h3>
      ) : (
        <Table
          columns={columns}
          loading={treatmentQuery.isPending}
          dataSource={treatmentQuery.data}
        />
      )}
    </>
  );
};

export default PatientTreatments;
