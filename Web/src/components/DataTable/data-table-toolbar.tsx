import { Cross2Icon } from "@radix-ui/react-icons";
import { Table } from "@tanstack/react-table";
import { Button } from "../ui/button";
import { DataTableViewOptions } from "./data-table-view-options";
import { Input } from "../ui/input";
import { DataTableFacetedFilter } from "./data-table-faceted-filter";
import { useTranslation } from "react-i18next";

interface DataTableToolbarProps<TData> {
  table: Table<TData>;
}

export function DataTableToolbar<TData>({
  table,
}: DataTableToolbarProps<TData>) {
  const isFiltered = table.getState().columnFilters.length > 0;
  const { t } = useTranslation();
  const Genders = [
    { label: t("gender.male"), value: 1 },
    { label: t("gender.female"), value: 0 },
  ];
  const ActiveState = [
    { label: t("form.notActive"), value: false },
    { label: t("form.active"), value: true },
  ];
  return (
    <div className="flex items-center justify-between">
      <div className="flex flex-1 items-center space-x-2">
        <Input
          placeholder={t("form.filterName")}
          value={
            (table.getColumn("fullNameArabic")?.getFilterValue() as string) ??
            ""
          }
          onChange={(event) =>
            table
              .getColumn("fullNameArabic")
              ?.setFilterValue(event.target.value)
          }
          className="h-8 w-[150px] lg:w-[250px] mx-3"
        />
        {table.getColumn("gender") && (
          <DataTableFacetedFilter
            column={table.getColumn("gender")}
            title={t("form.gender")}
            options={Genders}
          />
        )}
        {table.getColumn("activeField") && (
          <DataTableFacetedFilter
            column={table.getColumn("activeField")}
            title={t("form.activeField")}
            options={ActiveState}
          />
        )}
        {isFiltered && (
          <Button
            variant="ghost"
            onClick={() => table.resetColumnFilters()}
            className="h-8 px-2 lg:px-3"
          >
            Reset
            <Cross2Icon className="ml-2 h-4 w-4" />
          </Button>
        )}
      </div>
      <DataTableViewOptions table={table} />
    </div>
  );
}
