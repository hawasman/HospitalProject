import {
  AutoComplete,
  Col,
  DatePicker,
  Divider,
  Form,
  Input,
  Row,
  Select,
} from "antd";
import { useTranslation } from "react-i18next";
import { Gender, SocialState } from "../../Utils/Enums";

const Nationalities = [
  { value: "Burns Bay Road" },
  { value: "Downing Street" },
  { value: "Wall Street" },
];

const PatientCreatePage = () => {
  const { t } = useTranslation();
  const genders = [
    { value: Gender["ذكر"], label: t("gender.male") },
    { value: Gender["انثئ"], label: t("gender.female") },
  ];

  const SocialStates = [
    { value: SocialState["غير محدد"], label: t("socialState.undefined") },
    { value: SocialState["متزوج"], label: t("socialState.married") },
    { value: SocialState["اعزب"], label: t("socialState.single") },
    { value: SocialState["مطلق"], label: t("socialState.divorced") },
    { value: SocialState["ارملة"], label: t("socialState.widow") },
  ];

  return (
    <>
      <Divider>{t("form.patientInfo")}</Divider>
        <Form className="patient-form">
          <Row gutter={{ xs: 8, sm: 16, md: 24, lg: 32 }} justify="start">
            <Col span={8}className="gutter-row">
              <Form.Item className="col-2" label={t("form.fullNameArabic")}>
                <Input type="text" />
              </Form.Item>
            </Col>
            <Col span={8} className="gutter-row">
              <Form.Item className="col-2" label={t("form.fullNameEnglish")}>
                <Input type="text" />
              </Form.Item>
            </Col>
            <Col  className="gutter-row">
              <Form.Item className="col-2" label={t("form.birthDate")}>
                <DatePicker />
              </Form.Item>
            </Col>
            <Col span={4} className="gutter-row">
              <Form.Item className="col-2" label={t("form.nationality")}>
                <AutoComplete
                  style={{ width: "100%"}}
                  options={Nationalities}
                  placeholder={t("form.nationality")!}
                  filterOption={(inputValue, option) =>
                    option!.value
                      .toUpperCase()
                      .indexOf(inputValue.toUpperCase()) !== -1
                  }
                />
              </Form.Item>
            </Col>
            <Form.Item className="col-2" label={t("form.gender")}>
              <Select
                style={{ width: 100 }}
                options={genders}
                placeholder={t("form.gender")!}
              />
            </Form.Item>
            <Col span={6}>
              <Form.Item className="col-2" label={t("form.socialState")}>
                <Select
                  style={{ width: 200 }}
                  options={SocialStates}
                  placeholder={t("form.socialState")!}
                />
              </Form.Item>
            </Col>
            <Col span={6}>
              <Form.Item className="col-2" label={t("form.religion")}>
                <Input />
              </Form.Item>
            </Col>
            <Col span={6}>
              <Form.Item className="col-2" label={t("form.nationalId")}>
                <Input />
              </Form.Item>
            </Col>
            <Col span={6}>
              <Form.Item className="col-2" label={t("form.job")}>
                <Input />
              </Form.Item>
            </Col>
          </Row>
          <Divider>{t("form.contactInfo")}</Divider>
          <Row justify={"start"} gutter={{ xs: 8, sm: 16, md: 24, lg: 32 }} >
            <Col span={6}>
                <Form.Item className="col-2" label={t("form.phone1")}>
                  <Input />
                </Form.Item>
            </Col>
            <Col span={6} >
                <Form.Item className="col-2" label={t("form.phone2")}>
                  <Input />
                </Form.Item>
            </Col>
            <Col span={6} >
                <Form.Item className="col-2" label={t("form.mobilePhone")}>
                  <Input />
                </Form.Item>
            </Col>
            <Col span={6} >
                <Form.Item className="col-2" label={t("form.email")}>
                  <Input />
                </Form.Item>
            </Col>
            <Col span={6} >
                <Form.Item className="col-2" label={t("form.address")}>
                  <Input />
                </Form.Item>
            </Col>
            <Col span={6} >
                <Form.Item className="col-2" label={t("form.city")}>
                  <Input />
                </Form.Item>
            </Col>
          </Row>
        </Form>
    </>
  );
};

export default PatientCreatePage;
