// import { type Transporter, createTransport } from 'nodemailer'
// export class MailService {
//   transporter!: Transporter

//   constructor() {
//     this.transporter = createTransport({
//       host: 'smtp.gmail.com',
//       port: Number(587),
//       secure: false,
//       auth: {
//         user: 'nchat.msg@gmail.com',
//         pass: 'yqdybdrotudipeff'
//       }
//     })
//   }

//   /**
//    * * Отправить сообщение
//    */
//   async sendMail(options: any) {
//     await this.transporter.sendMail(options)
//   }
// }