import { UploadProps, message, Modal, FloatButton, Divider } from "antd";
import Dragger from "antd/es/upload/Dragger";
import { useState } from "react";
import { InboxOutlined, CloudUploadOutlined } from "@ant-design/icons";

const props: UploadProps = {
  name: "file",
  multiple: true,
  action: "https://run.mocky.io/v3/435e224c-44fb-4773-9faf-380c5e6a2188",
  onChange(info) {
    const { status } = info.file;
    if (status !== "uploading") {
      console.log(info.file, info.fileList);
    }
    if (status === "done") {
      message.success(`${info.file.name} تم رفع الملف بنجاح.`);
    } else if (status === "error") {
      message.error(`${info.file.name} فشل رفع الملف.`);
    }
  },
  onDrop(e) {
    console.log("Dropped files", e.dataTransfer.files);
  },
};

const PatientAttatchments = () => {
  const [showUpload, setShowUpload] = useState(false);
  return (
    <>
      <Modal
        title="رفع مستند جديد"
        centered
        open={showUpload}
        footer={null}
        onCancel={() => setShowUpload(false)}
      >
        <Divider></Divider>
        <Dragger {...props}>
          <p className="ant-upload-drag-icon">
            <InboxOutlined />
          </p>
          <p className="ant-upload-text">
            اضغط او اسحب ملفات هنا لرفعها
          </p>
          <p className="ant-upload-hint">
            يدعم رفع صور او فيديوهات, المستخدم مسؤول عن الملفات المرفعة الى الموقع.
          </p>
        </Dragger>
      </Modal>
      <FloatButton
        icon={<CloudUploadOutlined style={{fontSize:20, fontWeight: "bold"}}/>}
        onClick={() => setShowUpload(true)}
        tooltip={<p>رفع مستند جديد</p>}
        shape="square"
        style={{width:50, height:50}}
      />
      <h3 style={{ display: "block", textAlign: "center", padding: 70 }}>
        لا توجد بيانات
      </h3>
    </>
  );
};

export default PatientAttatchments;
