import { zodResolver } from "@hookform/resolvers/zod";
import * as z from "zod";
import { useForm } from "react-hook-form";
import {
  Form,
  FormControl,
  FormField,
  FormItem,
  FormLabel,
  FormMessage,
} from "@/components/ui/form";
import { Input } from "@/components/ui/input";

import { format } from "date-fns";
import { CalendarIcon, PlusIcon } from "lucide-react";
import { Calendar } from "@/components/ui/calendar";
import {
  Popover,
  PopoverContent,
  PopoverTrigger,
} from "@/components/ui/popover";
import { cn } from "@/lib/utils";
import { CardContent } from "@/components/ui/card";
import {
  DialogHeader,
  Dialog,
  DialogTrigger,
  DialogContent,
  DialogTitle,
} from "@/components/ui/dialog";
import { Card } from "antd";
import { useTranslation } from "react-i18next";
import { Button } from "@/components/ui/button";
import moment from "moment";
import {
  Select,
  SelectContent,
  SelectItem,
  SelectTrigger,
  SelectValue,
} from "@/components/ui/select";

import countries from "i18n-iso-countries";
import enCountries from "i18n-iso-countries/langs/en.json";
import arCountries from "i18n-iso-countries/langs/ar.json";
import { useMutation } from "@tanstack/react-query";
import { createPatient } from "@/Service/PatientService";
import { Patient } from "@/interfaces";

countries.registerLocale(arCountries);
countries.registerLocale(enCountries);

const formSchema = z.object({
  fullNameArabic: z.string().min(1).max(255),
  fullNameEnglish: z.string().min(1).max(255),
  birthDate: z.date(),
  gender: z.string(),
  socialState: z.string(),
  nationality: z.string().min(1).max(255),
  nationalId: z.string().min(1).max(255),
  religion: z.string().min(1).max(255),
  job: z.string().min(1).max(255).optional(),
  phone1: z.string().min(1).max(255),
  phone2: z.string().min(1).max(255).optional(),
  mobilePhone: z.string().min(1).max(255).optional(),
  email: z.string().email().min(1).max(255).optional(),
  address: z.string().min(1).max(255),
  city: z.string().min(1).max(255),
});

export default function PatientCreatePage() {
  const { t } = useTranslation();
  const mutation = useMutation({
    mutationFn: (newPatient: Patient) => {
      return createPatient(newPatient);
    },
  });
  const form = useForm<z.infer<typeof formSchema>>({
    resolver: zodResolver(formSchema),
    defaultValues: {
      fullNameArabic: "string",
      fullNameEnglish: "string",
      nationality: "string",
      nationalId: "string",
      religion: "string",
      job: "string",
      phone1: "string",
      phone2: "string",
      mobilePhone: "string",
      email: "string@string.com",
      address: "string",
      city: "string",
      birthDate: moment().toDate(),
      gender: "string",
      socialState: "string",
    },
  });

  const arCountriesObj = countries.getNames("ar", { select: "official" });

  async function onSubmit(values: z.infer<typeof formSchema>) {
    const newPatient: Patient = { ...values, gender: 0, socialState: 0 };
    newPatient.gender = values.gender == "male" ? 1 : 0;
    newPatient.socialState = (() => {
      switch (values.socialState) {
        case "undefined":
          return 0;
        case "married":
          return 1;
        case "single":
          return 2;
        case "divorced":
          return 3;
        case "widow":
          return 4;
        default:
          return 0;
      }
    })();
    newPatient.contactInfo = {
      phone1: values.phone1,
      phone2: values.phone2 ?? "",
      mobilePhone: values.mobilePhone ?? "",
      email: values.email ?? "",
      address: values.address,
      city: values.city,
    };
    await mutation.mutateAsync(newPatient);

    if (mutation.isSuccess) {
      console.log("success");
    }
  }

  return (
    <Dialog>
      <DialogTrigger asChild>
        <Button variant="outline">
          <PlusIcon />
        </Button>
      </DialogTrigger>
      <DialogContent
        className={"lg:max-w-screen-lg overflow-y-scroll max-h-screen"}
      >
        <DialogHeader className="flex items-center">
          <DialogTitle>{t("form.newPatient")}</DialogTitle>
        </DialogHeader>
        <div className="flex items-center space-x-2">
          <div className="grid flex-1 gap-2">
            <div className="">
              <Card>
                <CardContent>
                  <Form {...form}>
                    <form
                      onSubmit={form.handleSubmit(onSubmit)}
                      className="space-y-8"
                    >
                      <div className="grid grid-cols-3 gap-4 items-center">
                        <FormField
                          control={form.control}
                          name="fullNameArabic"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.fullNameArabic")}</FormLabel>
                              <FormControl>
                                <Input
                                  placeholder={t("form.fullNameArabic")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />

                        <FormField
                          control={form.control}
                          name="fullNameEnglish"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.fullNameEnglish")}</FormLabel>
                              <FormControl>
                                <Input
                                  placeholder={t("form.fullNameEnglish")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />
                        <FormField
                          control={form.control}
                          name="birthDate"
                          render={({ field }) => (
                            <FormItem className="flex flex-col">
                              <FormLabel>{t("form.birthDate")}</FormLabel>
                              <Popover>
                                <PopoverTrigger asChild>
                                  <FormControl>
                                    <Button
                                      variant={"outline"}
                                      className={cn(
                                        "w-[240px] pl-3 text-left font-normal",
                                        !field.value && "text-muted-foreground"
                                      )}
                                    >
                                      {field.value ? (
                                        format(field.value, "PPP")
                                      ) : (
                                        <span>Placeholder</span>
                                      )}
                                      <CalendarIcon className="ml-auto h-4 w-4 opacity-50" />
                                    </Button>
                                  </FormControl>
                                </PopoverTrigger>
                                <PopoverContent
                                  className="w-auto p-0"
                                  align="start"
                                >
                                  <Calendar
                                    mode="single"
                                    selected={field.value}
                                    onSelect={field.onChange}
                                    // disabled={(date) =>
                                    //   date > new Date() || date < new Date("1900-01-01")
                                    // }
                                    initialFocus
                                  />
                                </PopoverContent>
                              </Popover>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />
                      </div>

                      <div className="grid grid-cols-3 gap-4">
                        <FormField
                          control={form.control}
                          name="nationality"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.nationality")}</FormLabel>
                              <Select
                                onValueChange={field.onChange}
                                defaultValue={field.value}
                              >
                                <FormControl>
                                  <SelectTrigger>
                                    <SelectValue
                                      placeholder={t("form.nationality")}
                                    />
                                  </SelectTrigger>
                                </FormControl>
                                <SelectContent>
                                  {Object.entries(arCountriesObj).map(
                                    (value, key) => (
                                      <SelectItem key={key} value={value[0]}>
                                        {value[1]}
                                      </SelectItem>
                                    )
                                  )}
                                </SelectContent>
                              </Select>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />

                        <FormField
                          control={form.control}
                          name="nationalId"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.nationalId")}</FormLabel>
                              <FormControl>
                                <Input
                                  placeholder={t("form.nationalId")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />

                        <FormField
                          control={form.control}
                          name="religion"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.religion")}</FormLabel>
                              <FormControl>
                                <Input
                                  placeholder={t("form.religion")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />
                      </div>

                      <div className="grid grid-cols-3 gap-4">
                        <FormField
                          control={form.control}
                          name="gender"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.gender")}</FormLabel>
                              <Select
                                onValueChange={field.onChange}
                                defaultValue={field.value}
                              >
                                <FormControl>
                                  <SelectTrigger>
                                    <SelectValue
                                      placeholder={t("form.gender")}
                                    />
                                  </SelectTrigger>
                                </FormControl>
                                <SelectContent>
                                  <SelectItem value="male">
                                    {t("gender.male")}
                                  </SelectItem>
                                  <SelectItem value="female">
                                    {t("gender.female")}
                                  </SelectItem>
                                </SelectContent>
                              </Select>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />
                        <FormField
                          control={form.control}
                          name="socialState"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.socialState")}</FormLabel>
                              <Select
                                onValueChange={field.onChange}
                                defaultValue={field.value}
                              >
                                <FormControl>
                                  <SelectTrigger>
                                    <SelectValue
                                      placeholder={t("form.socialState")}
                                    />
                                  </SelectTrigger>
                                </FormControl>
                                <SelectContent>
                                  <SelectItem value="undefined">
                                    {t("socialState.undefined")}
                                  </SelectItem>
                                  <SelectItem value="single">
                                    {t("socialState.single")}
                                  </SelectItem>
                                  <SelectItem value="married">
                                    {t("socialState.married")}
                                  </SelectItem>
                                  <SelectItem value="divorced">
                                    {t("socialState.divorced")}
                                  </SelectItem>
                                  <SelectItem value="widow">
                                    {t("socialState.widow")}
                                  </SelectItem>
                                </SelectContent>
                              </Select>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />
                        <FormField
                          control={form.control}
                          name="job"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.job")}</FormLabel>
                              <FormControl>
                                <Input placeholder={t("form.job")} {...field} />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />

                        <FormField
                          control={form.control}
                          name="phone1"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.phone1")}</FormLabel>
                              <FormControl>
                                <Input
                                  placeholder={t("form.phone1")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />

                        <FormField
                          control={form.control}
                          name="phone2"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.phone2")}</FormLabel>
                              <FormControl>
                                <Input
                                  placeholder={t("form.phone2")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />

                        <FormField
                          control={form.control}
                          name="mobilePhone"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.mobilePhone")}</FormLabel>
                              <FormControl>
                                <Input
                                  placeholder={t("form.mobilePhone")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />
                        <FormField
                          control={form.control}
                          name="email"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.email")}</FormLabel>
                              <FormControl>
                                <Input
                                  type="email"
                                  placeholder={t("form.email")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />

                        <FormField
                          control={form.control}
                          name="address"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.address")}</FormLabel>
                              <FormControl>
                                <Input
                                  placeholder={t("form.address")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />

                        <FormField
                          control={form.control}
                          name="city"
                          render={({ field }) => (
                            <FormItem>
                              <FormLabel>{t("form.city")}</FormLabel>
                              <FormControl>
                                <Input
                                  placeholder={t("form.city")}
                                  {...field}
                                />
                              </FormControl>
                              {/* <FormDescription>Description</FormDescription> */}
                              <FormMessage />
                            </FormItem>
                          )}
                        />
                      </div>
                      <Button type="submit">{t("form.submit")}</Button>
                    </form>
                  </Form>
                </CardContent>
              </Card>
            </div>
          </div>
        </div>
      </DialogContent>
    </Dialog>
  );
}
