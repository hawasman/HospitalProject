import { Tooltip } from "antd";
import { useQuery } from "@tanstack/react-query";
import { getPatients } from "../Service/PatientService";
import { useTranslation } from "react-i18next";
import { DataTable } from "@/components/DataTable/data-table";
import { patientColumns } from "@/components/DataTable/columns";
import { Loader2 } from "lucide-react";
import PatientCreatePage from "./Patients/PatientCreatePage";

const PatientsPage = () => {
  const { isPending, isError, data } = useQuery({
    queryKey: ["patients"],
    queryFn: getPatients,
    initialData: [],
  });
  const { t } = useTranslation();

  if (isError) {
    return <span>حدث خطاء اثناء تحميل البيانات</span>;
  }

  return (
    <>
      <div className="flex justify-between">
        <h2>{t("patientList")}</h2>
        <div>
          <Tooltip title={t("form.newPatient")}>
            <PatientCreatePage />
          </Tooltip>
        </div>
      </div>
      <br />
      {isPending ? (
        <p>
          <Loader2 className="mr-2 h-4 w-4 animate-spin" />
          جاري التحميل
        </p>
      ) : (
        <DataTable columns={patientColumns} data={data} />
      )}
    </>
  );
};

export default PatientsPage;
