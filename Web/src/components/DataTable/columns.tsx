import { ColumnDef } from "@tanstack/react-table";
import { DataTableColumnHeader } from "./data-table-column-header";
import { DataTableRowActions } from "./data-table-row-actions";
import i18next from "i18next";
import { Patient } from "@/interfaces";

export const patientColumns: ColumnDef<Patient>[] = [
  {
    accessorKey: "id",
    header: ({ column }) => (
      <DataTableColumnHeader column={column} title={i18next.t("form.id")} />
    ),
    cell: ({ row }) => (
      <div className="flex items-center">{row.getValue("id")}</div>
    ),
  },
  {
    accessorKey: "fullNameArabic",
    header: ({ column }) => (
      <DataTableColumnHeader column={column} title={i18next.t("form.name")} />
    ),
    cell: ({ row }) => {
      return (
        <div className="flex space-x-2">
          <span className="max-w-[500px] truncate font-medium">
            {row.getValue("fullNameArabic")}
          </span>
        </div>
      );
    },
  },
  {
    accessorKey: "gender",
    header: ({ column }) => (
      <DataTableColumnHeader column={column} title={i18next.t("form.gender")} />
    ),
    cell: ({ row }) => {
      return (
        <div className="flex w-[100px] items-center">
          {row.getValue("gender") == "1"
            ? i18next.t("gender.male")
            : i18next.t("gender.female")}
        </div>
      );
    },
    filterFn: (row, id, value) => {
      return value.includes(row.getValue(id));
    },
  },
  {
    accessorKey: "nationality",
    header: ({ column }) => (
      <DataTableColumnHeader
        column={column}
        title={i18next.t("form.nationality")}
      />
    ),
    cell: ({ row }) => {
      return (
        <div className="flex items-center">{row.getValue("nationality")}</div>
      );
    },
    filterFn: (row, id, value) => {
      return value.includes(row.getValue(id));
    },
  },
  {
    accessorKey: "activeField",
    header: ({ column }) => (
      <DataTableColumnHeader
        column={column}
        title={i18next.t("form.activeField")}
      />
    ),
    cell: ({ row }) =>
      row.getValue("activeField")
        ? i18next.t("form.active")
        : i18next.t("form.notActive"),
    filterFn: (row, id, value) => {
      return value.includes(row.getValue(id));
    },
  },
  {
    id: "actions",
    cell: ({ row }) => <DataTableRowActions row={row} />,
  },
];
