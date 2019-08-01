/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package checkradiolistbox;

import javax.swing.DefaultListModel;
import javax.swing.JCheckBox;

/**
 *
 * @author Kemal
 */
public class ASd extends javax.swing.JFrame {

    /**
     * Creates new form ASd
     */
    String [][] matris,yerli,yabanci;
    DefaultListModel model;
    String tur;
    
    public ASd() {
        initComponents();
        
        String[][] tempMatris = {
            {"Memento", "Yabancı", "Dram", "2000"},
            {"The Green Mile", "Yabancı", "Dram", "1999"},
            {"Serendipity", "Yabancı", "Komedi", "2001"},
            {"The Patriot", "Yabancı", "Komedi", "2000"},
            {"12 Öfkeli Adam", "Yabancı", "Komedi", "2010"},
            {"12 Maymun", "Yabancı", "Bilim Kurgu", "2005"},
            {"2001: Bir Uzay Destanı", "Yabancı", "Bilim Kurgu", "2005"},
            {"Başka Semtin Çocukları", "Yabancı", "Dram", "2011"},
            {"Cesur Yürek", "Yerli", "Yabancı", "2009"},
            {"Çağrı", "Yerli", "Dram", "2006"},
            {"Çiçek Abbas", "Yerli", "Komedi", "2001"},
            {"Dedemin Fişi", "Yerli", "Komedi", "2016"},
            {"Duyguların Rengi", "Yerli", "Komedi", "2005"},
            {"Esaretin Bedeli", "Yabancı", "Dram", "2006"},
            {"Gladyatör", "Yabancı", "Aksiyon", "2005"},
            {"G.O.R.A.", "Yerli", "Komedi", "2002"},
            {"Daha Hızlı Daha Öfkeli", "Yabancı", "Aksiyon", "2012"},
            {"İnsan Lekesi", "Yerli", "Dram", "2012"},
            {"Kaplan ve Ejderha", "Yerli", "Aksiyon", "2016"},
            {"Kelebek", "Yerli", "Dram", "2003"},
            {"Kral Arthur", "Yabancı", "Bilim Kurgu", "2001"},
            {"Kutsal Damacana", "Yerli", "Komedi", "2006"},
            {"Kaçış Planı", "Yerli", "Aksiyon", "2003"},
            {"Matrix", "Yabancı", "Bilim Kurgu", "2001"},
            {"Münih", "Yabancı", "Dram", "2005"},
            {"Neşeli hayat", "Yerli", "Komedi", "2015"}
        };

        matris = tempMatris;
        model = new DefaultListModel();
        for (int i = 0; i < matris.length; i++) {
            model.addElement(matris[i][0]);
        }
        jList1.setModel(model);
        jPanel1.setVisible(false);
        jPanel2.setVisible(false);
    }
    
    public void tur_list(DefaultListModel liste)
    {
        model = liste;
        if(jRadioButton1.isSelected()==true)
        {
            for(int i=0; i<yerli.length ;i++)
            {
                tur = yerli[i][2];
                if(yerli[i][2]==jCheckBox1.getText())
                {
                    if(jCheckBox1.isSelected()==false)
                        model.removeElement(matris[i][0]);
                    /*else
                        model.addElement(matris[i][0]);*/
                }
                else if(yerli[i][2]==jCheckBox2.getText())
                {
                    if(jCheckBox2.isSelected()==false)
                        model.removeElement(matris[i][0]);
                    /*else
                        model.addElement(matris[i][0]);*/
                }
                else if(yerli[i][2]==jCheckBox3.getText())
                {
                    if(jCheckBox3.isSelected()==false)
                        model.removeElement(matris[i][0]);
                    /*else
                        model.addElement(matris[i][0]);*/
                }
                else if(yerli[i][2]==jCheckBox4.getText())
                {
                    if(jCheckBox4.isSelected()==false)
                        model.removeElement(matris[i][0]);
                    /*else
                        model.addElement(matris[i][0]);*/
                }
            }
        }
        else
        {
            for(int i=0; i<yabanci.length ;i++)
            {
                tur = yabanci[i][2];
                if(yabanci[i][2]==jCheckBox1.getText())
                {
                    if(jCheckBox1.isSelected()==false)
                        model.removeElement(matris[i][0]);
                    /*else
                        model.addElement(matris[i][0]);*/
                }
                else if(yabanci[i][2]==jCheckBox2.getText())
                {
                    if(jCheckBox2.isSelected()==false)
                        model.removeElement(matris[i][0]);
                    /*else
                        model.addElement(matris[i][0]);*/
                }
                else if(yabanci[i][2]==jCheckBox3.getText())
                {
                    if(jCheckBox3.isSelected()==false)
                        model.removeElement(matris[i][0]);
                    /*else
                        model.addElement(matris[i][0]);*/
                }
                else if(yabanci[i][2]==jCheckBox4.getText())
                {
                    if(jCheckBox4.isSelected()==false)
                        model.removeElement(matris[i][0]);
                    /*else
                        model.addElement(matris[i][0]);*/
                }
            }
        }
        
        jList1.setModel(model);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        buttonGroup1 = new javax.swing.ButtonGroup();
        jScrollPane1 = new javax.swing.JScrollPane();
        jList1 = new javax.swing.JList<>();
        jPanel1 = new javax.swing.JPanel();
        jRadioButton1 = new javax.swing.JRadioButton();
        jRadioButton2 = new javax.swing.JRadioButton();
        jPanel2 = new javax.swing.JPanel();
        jCheckBox1 = new javax.swing.JCheckBox();
        jCheckBox2 = new javax.swing.JCheckBox();
        jCheckBox3 = new javax.swing.JCheckBox();
        jCheckBox4 = new javax.swing.JCheckBox();
        jButton1 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jScrollPane1.setViewportView(jList1);

        jPanel1.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));

        buttonGroup1.add(jRadioButton1);
        jRadioButton1.setText("Yerli");
        jRadioButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jRadioButton1ActionPerformed(evt);
            }
        });

        buttonGroup1.add(jRadioButton2);
        jRadioButton2.setText("Yabancı");
        jRadioButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jRadioButton2ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jRadioButton1)
                    .addComponent(jRadioButton2))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(16, 16, 16)
                .addComponent(jRadioButton1)
                .addGap(18, 18, 18)
                .addComponent(jRadioButton2)
                .addContainerGap(20, Short.MAX_VALUE))
        );

        jPanel2.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));

        jCheckBox1.setSelected(true);
        jCheckBox1.setText("Komedi");
        jCheckBox1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox1ActionPerformed(evt);
            }
        });

        jCheckBox2.setSelected(true);
        jCheckBox2.setText("Aksiyon");
        jCheckBox2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox2ActionPerformed(evt);
            }
        });

        jCheckBox3.setSelected(true);
        jCheckBox3.setText("Dram");
        jCheckBox3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox3ActionPerformed(evt);
            }
        });

        jCheckBox4.setSelected(true);
        jCheckBox4.setText("Bilim-Kurgu");
        jCheckBox4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox4ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jCheckBox1)
                    .addComponent(jCheckBox2)
                    .addComponent(jCheckBox3)
                    .addComponent(jCheckBox4))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jCheckBox1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jCheckBox2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jCheckBox3)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jCheckBox4)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        jButton1.setText("Filtrele");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButton1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addGap(21, 21, 21)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 234, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(7, 7, 7)
                        .addComponent(jButton1)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 22, Short.MAX_VALUE))
                    .addComponent(jScrollPane1))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        jPanel1.setVisible(true);
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jRadioButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jRadioButton1ActionPerformed
        jPanel2.setVisible(true);
        DefaultListModel yerli_model = new DefaultListModel();
        model.removeAllElements();
        for(int i=0,j=0; i<matris.length ; i++)
        {
            if(matris[i][1]=="Yerli")
            {
                yerli[j]=matris[i];
                j++;
                model.addElement(matris[i][0]);
            }
        }
        jList1.setModel(yerli_model);
    }//GEN-LAST:event_jRadioButton1ActionPerformed

    private void jRadioButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jRadioButton2ActionPerformed
        jPanel2.setVisible(true);
        model = new DefaultListModel();
        model.removeAllElements();
        for(int i=0,j=0; i<matris.length ;i++)
        {
            if(matris[i][1]=="Yabancı")
            {
                yabanci[j]=matris[i];
                j++;
                model.addElement(matris[i][0]);
            }
        }
        jList1.setModel(model);
    }//GEN-LAST:event_jRadioButton2ActionPerformed

    private void jCheckBox1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox1ActionPerformed
        tur_list(model);
    }//GEN-LAST:event_jCheckBox1ActionPerformed

    private void jCheckBox2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox2ActionPerformed
        tur_list(model);
    }//GEN-LAST:event_jCheckBox2ActionPerformed

    private void jCheckBox3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox3ActionPerformed
        tur_list(model);
    }//GEN-LAST:event_jCheckBox3ActionPerformed

    private void jCheckBox4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox4ActionPerformed
        tur_list(model);
    }//GEN-LAST:event_jCheckBox4ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(ASd.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ASd.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ASd.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ASd.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ASd().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.JButton jButton1;
    private javax.swing.JCheckBox jCheckBox1;
    private javax.swing.JCheckBox jCheckBox2;
    private javax.swing.JCheckBox jCheckBox3;
    private javax.swing.JCheckBox jCheckBox4;
    private javax.swing.JList<String> jList1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JRadioButton jRadioButton1;
    private javax.swing.JRadioButton jRadioButton2;
    private javax.swing.JScrollPane jScrollPane1;
    // End of variables declaration//GEN-END:variables
}
